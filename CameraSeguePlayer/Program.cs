using System;
using System.Collections.Generic;
using UnityEngine;

namespace CameraSeguePlayer
{
    class CameraSeguePlayer : MonoBehaviour
    {
        [SerializeField]
        private Vector3 offSet;

        [Range(0,1)]
        public float suv = 0.2f;
        public Transform player;

        private void FixedUpdate()
        {
            transform.position = Vector3.Lerp(transform.position, player.position + offSet, suv);
            transform.LookAt(player);
        }
    }
}
