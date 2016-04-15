using UnityEngine;
using System.Collections;

namespace TLB
{
    public class CameraController : MonoBehaviour
    {
        public GameObject player;
        private Vector3 offset;

        // Use this for initialization
        void Start()
        {
            // Referances the camera position and the players position
            offset = transform.position - player.transform.position;
        }

        // Runs after Update, once per frame
        void LateUpdate()
        {

            transform.position = player.transform.position + offset;
        }
    }
}