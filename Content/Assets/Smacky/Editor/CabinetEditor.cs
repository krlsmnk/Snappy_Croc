using UnityEngine;
using UnityEditor;

using Recolude.Smacky;

namespace Recolude.SmackyEditor
{

    [CustomEditor(typeof(Cabinet))]
    public class CabinetEditor : UnityEditor.Editor
    {
        void OnEnable()
        {
            SceneView.duringSceneGui += OnSceneGUI;
        }

        void OnDisable()
        {
            SceneView.duringSceneGui -= OnSceneGUI;
        }

        RaycastHit DownIntersect(Vector3 p1)
        {
            RaycastHit hit;
            Physics.Raycast(p1, Vector3.down, out hit, 100);
            return hit;
        }

        protected virtual void OnSceneGUI(SceneView sceneView)
        {
            var cabinet = (Cabinet)target;
            if (cabinet == null)
            {
                return;
            }

            var holePositions = cabinet.HolePositions();
            foreach (var pos in holePositions)
            {
                Handles.color = Color.yellow;
                Handles.DrawSolidDisc(pos, cabinet.Normal(), 0.5f);
                Handles.color = Color.red;
                Handles.DrawLine(pos, pos + (cabinet.Normal().normalized * cabinet.ExtensionLength()));
            }

        }

        public override void OnInspectorGUI()
        {
            var cabinet = (Cabinet)target;

            if (cabinet == null)
            {
                return;
            }

            base.OnInspectorGUI();
        }


    }

}