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
        Quaternion angle = Quaternion.LookRotation(Vector3.forward, transform.position - player.transform.position);
        player.transform.rotation = angle;
    }
}