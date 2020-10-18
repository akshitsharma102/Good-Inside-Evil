using player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace player
{
    public class playerMovement : MonoBehaviour
    {
        
        //mains
        private Rigidbody2D rb2d;
        
        
        

        //movement
        public float MovementSpeed;
        public bool facingRight = true;
        //jump
        public float jumpForce;
        public float jumpDuration, maxDuration = 1f;
        private bool grounded = false;
        private LayerMask whatIsGround;
        public Transform ground;
        public float groundRadious = 0.2f;
        //croutch

        //dash

        //animator
        void Awake()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            grounded = Physics2D.OverlapCircle(ground.position, groundRadious, whatIsGround);

            float move = Input.GetAxis("Horizontal");

            rb2d.velocity = new Vector2(move * MovementSpeed, rb2d.velocity.y);

            if (move > 0 && !facingRight)
                flip();
            else if (move < 0 && facingRight)
                flip();
        }
        void Update()
        {

        }
        public void flip()
        {
            facingRight = !facingRight;
            Vector3 TheScale = transform.localScale;
            TheScale.x *= -1;
            transform.localScale = TheScale;
        }
    }
}

