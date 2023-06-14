using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [AllowsNull]public GameObject movementTarget = null;
    public float movementSpeed = 20;

    // Update is called once per frame
    void Update()
    {
        if (movementTarget && transform.parent is null)
        {
            MoveTowardsTarget();
        }
    }

    void MoveTowardsTarget()
    {
        Vector2 position = transform.position;
        Vector2 targetPosition = movementTarget.transform.position;
        transform.position = Vector2.MoveTowards(
            position,
            targetPosition, 
            movementSpeed * Time.deltaTime
            );
        
        if (position == (Vector2)movementTarget.transform.position)
        {
            transform.parent = movementTarget.transform;
            SetGravity();
        }
    }

    public void SetGravity()
    {
        Rigidbody2D body = GetComponent<Rigidbody2D>();
        if (transform.parent is not null)
        {
            body.simulated = false;
        }
        else
        {
            body.simulated = true;
        }
    }
}
