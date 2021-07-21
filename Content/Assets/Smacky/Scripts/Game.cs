using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Recolude.Smacky
{

    [System.Serializable]
    [CreateAssetMenu(menuName = "Smacky/Game", fileName = "Game")]
    public class Game : ScriptableObject
    {

        [SerializeField]
        private Cabinet cabinet;

        [SerializeField]
        private Wave[] waves;

        public GameBehavior Build()
        {
            var gameObj = new GameObject("Game");
            return GameBehavior.Build(gameObj, cabinet.Build(), waves);
        }

    }

}