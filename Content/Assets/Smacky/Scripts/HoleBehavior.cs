using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Recolude.Smacky
{

    public class HoleBehavior : MonoBehaviour
    {

        private GameObject character;

        private float distanceToExend;

        public static HoleBehavior Build(GameObject obj, GameObject character, float distanceToExend)
        {
            var instance = obj.AddComponent<HoleBehavior>();
            instance.character = character;
            instance.distanceToExend = distanceToExend;
            return instance;
        }

        internal void ShowCharacter(float characterSpeed)
        {
            StartCoroutine(ShowCharacterCoroutine(characterSpeed));
        }

        private Vector3 FullyRetractedPosition()
        {
            return transform.position - (transform.up * .5f);
        }

        private Vector3 FullyProtractedPosition()
        {
            return transform.position + (transform.up * distanceToExend);
        }

        private float CharacterDistanceFromFullExtension()
        {
            return Vector3.Distance(character.transform.position, FullyProtractedPosition());
        }

        private float CharacterDistanceFromFullRetraction()
        {
            return Vector3.Distance(character.transform.position, FullyRetractedPosition());
        }

        IEnumerator ShowCharacterCoroutine(float characterSpeed)
        {
            float timeStarted = Time.time;
            float epsilon = 0.01f;
            while (CharacterDistanceFromFullExtension() < -epsilon || CharacterDistanceFromFullExtension() > epsilon)
            {
                character.transform.position = Vector3.Lerp(FullyRetractedPosition(), FullyProtractedPosition(), (Time.time - timeStarted) / characterSpeed);
                yield return null;
            }

            timeStarted = Time.time;
            while (CharacterDistanceFromFullRetraction() < -epsilon || CharacterDistanceFromFullRetraction() > epsilon)
            {
                character.transform.position = Vector3.Lerp(FullyProtractedPosition(), FullyRetractedPosition(), (Time.time - timeStarted) / characterSpeed);
                yield return null;
            }
        }

    }

}