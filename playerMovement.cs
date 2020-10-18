using player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace player
{
    public class playerMovement : MonoBehaviour
    {
        public float MovementSpeed;
        public float jumpForce;
        public float jumpDuration, maxDuration = 1f;
        private Rigidbody2D rb2d;
        public Transform ground;
        private LayerMask whatIsGround;
        private bool grounded = false;
        void Awake()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {

        }
        void Update()
        {

        }
        public void flip()
        {

        }
    }
}

