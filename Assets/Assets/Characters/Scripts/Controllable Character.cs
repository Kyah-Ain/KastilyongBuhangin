using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllableCharacter : MonoBehaviour
{
    public Rigidbody2D bubble;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Game Over") != null && GameObject.Find("Game Over").activeSelf)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            bubble.velocity = new Vector2(-5, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            bubble.velocity = new Vector2(5, 0);
        }
    }
}
