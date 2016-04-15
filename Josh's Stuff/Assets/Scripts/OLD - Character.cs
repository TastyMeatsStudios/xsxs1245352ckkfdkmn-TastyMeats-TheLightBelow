using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
    Animator anim;
    Rigidbody2D playerRigidbody;

    public float maxSpeed = 10;
    bool facingRight = true;
    bool facingUpRight = true;
    bool facingDownRight = true;

    void Awake ()
    {
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float move = Input.GetAxis("Horizontal");

        playerRigidbody.velocity = new Vector2(move * maxSpeed, playerRigidbody.velocity.y);
	}
}
