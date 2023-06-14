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
    }
}
