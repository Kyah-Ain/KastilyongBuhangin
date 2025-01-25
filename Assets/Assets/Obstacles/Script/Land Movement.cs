using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandMovement : MonoBehaviour
{
    public float movementSpeed = 5;
    public float despawnZone = -9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * movementSpeed) * Time.deltaTime;

        if (transform.position.y < despawnZone)
        {
            Destroy(gameObject);
        }
    }
}
