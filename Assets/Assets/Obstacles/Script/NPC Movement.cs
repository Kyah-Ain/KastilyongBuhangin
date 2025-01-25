using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovements : MonoBehaviour
{
    public float movementSpeed = 5; // Speed at which the NPC moves downward
    public float despawnZone = -9; // Y-coordinate below which the NPC is reset
    public float respawnHeight = 10; // Y-coordinate where the NPC respawns
    public float respawnXRange = 5; // Range for random X-position during respawn

    // Update is called once per frame
    void Update()
    {
        // Move the NPC downward
        transform.position += Vector3.down * movementSpeed * Time.deltaTime;

        // Check if the NPC has moved below the despawn zone
        if (transform.position.y < despawnZone)
        {
            // Generate a random X position within the specified range
            float randomX = Random.Range(-respawnXRange, respawnXRange);

            // Reset the NPC's position to the new random position
            transform.position = new Vector3(randomX, respawnHeight, transform.position.z);
        }
    }
}
