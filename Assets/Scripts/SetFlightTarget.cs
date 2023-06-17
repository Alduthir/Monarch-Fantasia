using UnityEngine;

public class SetFlightTarget : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject player = GameObject.FindWithTag("Player");
        PlayerController controller = player.GetComponent<PlayerController>();
        controller.movementTarget = gameObject;
        if (player.transform.parent != null)
        {
            player.transform.parent = null;
            controller.SetGravity();
        }
        RotateToTarget(player.transform);
    }
    
    private void RotateToTarget(Transform player)
    {
        float angle = Mathf.Atan2(
             transform.position.y, 
             transform.position.x
        );
        player.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
