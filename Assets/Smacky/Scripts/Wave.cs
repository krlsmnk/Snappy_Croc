using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Recolude.Smacky
{

    [System.Serializable]
    public class Wave
    {

        [SerializeField]
        private float timeBetweenSpawns;

        [SerializeField]
        private float characterSpeed;

        [SerializeField]
        private int numSpawns;

        public IEnumerator Run(CabinetBehavior cabinent)
        {
            for (int i = 0; i < numSpawns; i++)
            {
                cabinent.ShowCharacter(characterSpeed);
                yield return new WaitForSeconds(timeBetweenSpawns);
            }
        }

    }

}