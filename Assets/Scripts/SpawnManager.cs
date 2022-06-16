using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Create an array to store the animals that will be spawned
    public GameObject[] animalPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        // Pick a random animal to spawn
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // Creating the random spawn position for each animal
        Vector3 spawnPosition = new Vector3(Random.Range(-20, 20), 0, 25);

        // Create the animal objects and have them spawn at random locations
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
