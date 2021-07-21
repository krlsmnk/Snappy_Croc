using UnityEngine;

namespace Recolude.Smacky
{

    public class CabinetBehavior : MonoBehaviour
    {

        HoleBehavior[] holes;

        public static CabinetBehavior Build(GameObject obj, HoleBehavior[] holes)
        {
            var instance = obj.AddComponent<CabinetBehavior>();
            instance.holes = holes;

            return instance;
        }

        internal void ShowCharacter(float characterSpeed)
        {
            holes[Random.Range(0, holes.Length)].ShowCharacter(characterSpeed);
        }
    }

}