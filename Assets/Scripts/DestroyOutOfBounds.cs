using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -8)
        {
            DetachPlayer();
            Destroy(gameObject);
        }
    }
    
    void DetachPlayer()
    {
        if (transform.childCount == 0)
        {
            return;
        }
        
        Transform player = transform.Find("Player");
        if (player is not null)
        {
            PlayerController controller = player.GetComponent<PlayerController>();
            player.transform.parent = null;
            controller.SetGravity();
            controller.movementTarget = null;
        }
    }
}
