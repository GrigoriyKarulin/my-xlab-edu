using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
    public class PlayerController : MonoBehaviour
    {
        public Spawner spawner;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("X key down");
                spawner.Spawn();
            }
        }
    }
}