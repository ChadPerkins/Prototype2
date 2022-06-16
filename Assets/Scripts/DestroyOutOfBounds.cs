using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    float upperBound = 35;
    float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Create the top bountry for the game
        if (transform.position.z > upperBound)
        {
            // Destroy the current game object the script is attached to
            Destroy(gameObject);
            // Create the bottom bountry for the game
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
