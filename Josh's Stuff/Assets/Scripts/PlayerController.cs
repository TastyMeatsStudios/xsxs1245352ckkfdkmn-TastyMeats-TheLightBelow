using UnityEngine;
using System.Collections;

namespace TLB
{
    public class PlayerController : MonoBehaviour
    {
        public float maxSpeed = 10f; // maximum speed can be edited in unity
        bool facingRight = true; // Makes it easier on artists by flipping the model rather than redrawing in opposite direction
        Animator anim;

        // Use this for initialization
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void FixedUpdate()
        {
            float horizontalMovement = Input.GetAxis("Horizontal");
            float verticalMovement = Input.GetAxis("Vertical");

            anim.SetFloat("vSpeed", Mathf.Abs(verticalMovement));
            anim.SetFloat("Speed", Mathf.Abs(horizontalMovement));

            GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalMovement*maxSpeed, verticalMovement * maxSpeed);

            if (horizontalMovement > 0 )
            {
                if (!facingRight)
                {
                    Flip();
                }
                gameObject.GetComponentInChildren<PolygonCollider2D>().transform.localRotation = Quaternion.Euler(0,0,270);
            }
             if (horizontalMovement < 0 )
            {
                if (facingRight)
                {
                    Flip();
                }

                gameObject.GetComponentInChildren<PolygonCollider2D>().transform.localRotation = Quaternion.Euler(0, 0, 270);
            }
             if (verticalMovement > 0)
            {
                gameObject.GetComponentInChildren<PolygonCollider2D>().transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
             if (verticalMovement < 0)
            {
                gameObject.GetComponentInChildren<PolygonCollider2D>().transform.localRotation = Quaternion.Euler(0, 0, 180);
            }
            if (Input.GetMouseButtonDown(1))
            {
            }
        }

        void Flip()
        {
            facingRight = !facingRight; // Flips the current bool type
            Vector3 theScale = transform.localScale; // Creates 3 dimentional vector
            theScale.x *= -1; // sets new graphic value for flipping
            transform.localScale = theScale; // Flips the graphic and then returns
        }
    }
}