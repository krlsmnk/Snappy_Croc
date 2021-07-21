using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Recolude.Smacky
{

    public class SmackyManager : MonoBehaviour
    {

        [SerializeField]
        Game game;

        void Start()
        {
            game.Build().StartGame();
        }

    }

}