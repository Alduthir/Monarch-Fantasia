using System;
using UnityEngine;

public class FlowerController : MonoBehaviour
{
    public float nectar = 1;

    // Update is called once per frame
    void Update()
    {
        if (transform.Find("Player") is not null)
        {
            nectar -= Time.deltaTime;
            Debug.Log("Absorbing nectar. Amount left: " + nectar);

            if (nectar <= 0)
            {
                Debug.Log("Nectar fully absorbed");
                DetachPlayer();
                Destroy(gameObject);
            }
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
