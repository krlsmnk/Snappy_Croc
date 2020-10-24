using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Recolude.Smacky
{

    [System.Serializable]
    [CreateAssetMenu(menuName = "Smacky/Cabinet", fileName = "Cabinet")]
    public class Cabinet : ScriptableObject
    {

        [SerializeField]
        private int rows = 4;

        [SerializeField]
        private int columns = 4;

        [SerializeField]
        private Vector3 normal = Vector3.up;

        [SerializeField]
        private float extensionLength = .33f;

        [SerializeField]
        private GameObject holePrefab;


        [SerializeField]
        private GameObject characterPrefab;

        public int Rows()
        {
            return rows;
        }

        public int Columns()
        {
            return columns;
        }

        public Vector3 Normal()
        {
            return normal;
        }

        public float ExtensionLength()
        {
            return this.extensionLength;
        }

        public Vector3[] HolePositions()
        {
            Vector3[] positions = new Vector3[Rows() * Columns()];

            // @Karl, if you're confused about what's going on, check out this video
            // https://www.youtube.com/watch?v=kYB8IZa5AuE
            var n = Normal();
            Vector3 noncolinear = Vector3.up; // Doing fucking anything to make sure not colinear, fails in case where normal is Vector3.zero 
            if (n.normalized.Equals(noncolinear) || n.normalized.Equals(noncolinear * -1))
            {
                noncolinear = Vector3.right;
            }
            Vector3 crossed = Vector3.Cross(n, noncolinear);
            Matrix4x4 m = new Matrix4x4(crossed.normalized, n.normalized, Vector3.Cross(crossed, n).normalized, Vector4.zero);
            int i = 0;
            for (int x = 0; x < Rows(); x++)
            {
                for (int y = 0; y < Columns(); y++)
                {
                    var pos = m.MultiplyVector(new Vector3(x, 0, y));
                    positions[i] = pos;
                    i++;
                }
            }
            return positions;
        }

        public CabinetBehavior Build()
        {
            var holePositions = HolePositions();
            HoleBehavior[] holes = new HoleBehavior[holePositions.Length];

            GameObject cabinent = new GameObject(this.name);

            for (int i = 0; i < holePositions.Length; i++)
            {
                var pos = holePositions[i];
                var holeInstance = Instantiate<GameObject>(holePrefab, pos, Quaternion.FromToRotation(Vector3.up, normal));
                holeInstance.transform.SetParent(cabinent.transform);

                var characterInstance = Instantiate<GameObject>(characterPrefab, pos - (Normal().normalized * .5f), Quaternion.FromToRotation(Vector3.up, normal));
                characterInstance.transform.SetParent(holeInstance.transform);
                holes[i] = HoleBehavior.Build(holeInstance, characterInstance, ExtensionLength());
            }

            return CabinetBehavior.Build(cabinent, holes);
        }

    }

}
