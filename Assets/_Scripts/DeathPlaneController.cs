using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        // check if the object that triggers a collision is a player
        if (other.gameObject.CompareTag("Player"))
        {
            // get a reference to player controller
            var controller = other.gameObject.GetComponent<CharacterController>();
            // turn controller off
            controller.enabled = false;
            // move the player to the spawn point
            other.gameObject.transform.position = spawnPoint.position;
            // turn controller on
            controller.enabled = true;
        }
    }
}
