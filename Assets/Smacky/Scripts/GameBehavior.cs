using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace Recolude.Smacky
{

    public class GameBehavior : MonoBehaviour
    {

        CabinetBehavior cabinent;

        Wave[] waves;

        public static GameBehavior Build(GameObject obj, CabinetBehavior cabinent, Wave[] waves)
        {
            var instance = obj.AddComponent<GameBehavior>();
            instance.cabinent = cabinent;
            instance.waves = waves;
            return instance;
        }

        internal void StartGame()
        {
            StartCoroutine(GamePlay());
        }

        IEnumerator GamePlay()
        {
            foreach (var wave in waves)
            {
                yield return wave.Run(cabinent);
            }
        }
    }

}