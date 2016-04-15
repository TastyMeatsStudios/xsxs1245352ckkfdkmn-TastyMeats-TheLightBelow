/*
using UnityEngine;
using System.Collections;

public class Player : MovingObject
{
    public float restartLevelDelay = 1f; // in seconds
    public int Health = 20;

    private Animator animator;
    
    // Start overrides the start function of movingobject
    protected override void Start()
    {
        // Get component referance to the players animator component
        animator = GetComponent<animator>();

        // Calls the Start function in MovingObject
        base.Start();
    }

    private void OnDisable ()
    {
        // When player object is disabled, store the current health stats in the GameManager so it can be re-loaded in the next level
        GameManager.instance.playerHitPoints = Health;
    }
	
	// Update is called once per frame
	private void Update ()
    {
        if (!GameManager.instance.playersTurn) return;

        int horizontal = 0; // Stores the horizontal movement
        int vertical = 0; // Stores the vertical movement

        // Gets input from the input manager, rounds it and stores in horizontal so it can set the move direction of the x axis
        horizontal = (int)(Input.GetAxisRaw("Horizontal")); // Gets button name "Horizontal" input

        // Does the same with the y axis and vertical button
        vertical = (int)(Input.GetAxisRaw("Vertical"));

        // Check if there is a non 0 input for x or y
        if (horizontal != 0 || vertical != 0)
        {
            // Calls AttemptMove and passes in horizontal and vertical values
            AttemptMove<Wall>(horizontal, vertical);
        }
	}

    protected override void AttemptMove <T> (int xDirection, int yDirection)
    {
        // Calls the base class' move method
        base.AttemptMove<T>(xDirection, yDirection);

        // Hit allows us to referance the result of the linecast done in move
        RaycastHit2D hit;

        // If move returns true, meaning player was able to move into an empty space
    }
    protected override void OnCantMove <T> (T component)
    {
        Wall hitWall = component as Wall;
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        // Check if tag with collider is tied with exit
        if (other.tag == "Exit")
        {
            // Invokes the restart function to restart with a delay from restartLevelDelay
            Invoke("Restart", restartLevelDelay);

            //Disable the players object because you ended the level
            enabled = false;
        }

        // Restart reloads the scene when called
        {
            /// load the last scene loaded, in this case the Main
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void LoseHealth (int damage)
    {
        // Activates the saved animation for player hit
        animator.SetTrigger("playerHit");

        // Takes damage given as input
        Health -= damage;

        // Check to see of game has ended
        CheckIfGameOver();
    }

    // CheckIfGameOver checks if the player runs out of health, if he has the game ends
    private void CheckIfGameOver ()
    {
        if (Health <= 0)
        {
            // Calls the gameover function of Game Manager
            GameManager.instance.GameOver();
        }
    }
}
*/