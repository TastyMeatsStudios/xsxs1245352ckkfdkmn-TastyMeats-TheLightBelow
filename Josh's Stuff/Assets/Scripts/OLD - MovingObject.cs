/*
using UnityEngine;
using System.Collections;

public abstract class MovingObject : MonoBehaviour
{
    public float moveTime = 0.1f;           // Time in seconds it takes to move something
    public LayerMask blockingLayer;         // Layer that will check for collision


    private BoxCollider2D boxCollider;      // The BoxCollider2D object tied to this object
    private Rigidbody2D rBod2D;             // The RigidBody2D object tied to this object
    private float inverseMoveTime;          // Used to make movement more efficient.


    // Can be overriden by inheriting classes
    protected virtual void Start()
    {
        // Get a component reference to this objects BoxCollider2D
        boxCollider = GetComponent<BoxCollider2D>();

        // Get a component reference to this objects RigidBody2D
        rBod2D = GetComponent<Rigidbody2D>();

        inverseMoveTime = 1f / moveTime;
    }

    // Move returns true if able to move and false if not
    // Move takes parameters for x direction, y direction and a RayCast2D to check collision
    protected bool Move(int xDirection, int yDirection, RaycastHit2D hit)
    {
        // Store start position to move from, based on objects current transform position
        Vector2 start = transform.position;

        // Calculate end position based on the direction parameters passed in when calling Move
        Vector2 end = start + new Vector2(xDirection, yDirection);

        // Disable the boxCollider so that linecast dosen't hit this object's own collider
        boxCollider.enabled = false;

        // Check if anything was hit
        if (hit.transform == null)
        {
            // If nothing was hit, start SmoothMovement passing in the Vector2 end as destination
            StartCoroutine(SmoothMovement(end));

            // Return true to say that the move was successful
            return true;
        }
        // If something was hit, return false because the move was unsuccessful
        return false;
    }

    // For moving units from one space to the next, takes a paramater end to specify where to move to
    protected IEnumerator SmoothMovement(Vector3 end)
    {
        // Calculate the remaining distance to move based on the distance between current and end spot
        float sqrRemainingDistance = (transform.position - end).sqrMagnitude;

        // While that distance is greater than a very small amount (almost zero):
        while (sqrRemainingDistance > float.Epsilon)
        {
            // Find a new position closer to the end based on the moveTime
            Vector3 newPosition = Vector3.MoveTowards(rBod2D.position, end, inverseMoveTime * Time.deltaTime);

            // Calls move position on the attached RigidBody
            rBod2D.MovePosition(newPosition);

            // Recalculate the remaining distance after moving
            sqrRemainingDistance = (transform.position - end).sqrMagnitude;

            // Return and look until sqrRemainingDistance is close enough to zero to end the entire function
            yield return null;
        }
    }

    protected virtual void AttemptMove<T>(int xDirection, int yDirection)
        where T : Component
    {
        // Hit will store whatever our linecast hits when Move is called
        RaycastHit2D hit = new RaycastHit2D(); // TODO: set the approprate value

        bool canMove = Move(xDirection, yDirection, hit);

        // Check if nothing was hit by the linecast
        if (hit.transform == null)
            return;

        // Get a component referance to the component of type T attached tot he object that was hit
        T hitComponent = hit.transform.GetComponent<T>();

        // if canMove is false and hitComponent is == null, meaning MovingObject is blocked and has hit something it can interact with
        if (!canMove && hitComponent != null)
            OnCantMove(hitComponent);

    }
    protected abstract void OnCantMove<T>(T component)
        where T : Component;
}
*/