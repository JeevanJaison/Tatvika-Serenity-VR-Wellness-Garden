using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner9 : MonoBehaviour
{
    public GameObject[] fruits;
    public GameObject[] rotten;
    public GameObject bomb;

    public float xBounds, yBounds, minDuration, maxDuration;
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(minDuration, maxDuration));
        int randomFruit = Random.Range(0, fruits.Length);
        int randomRotten = Random.Range(0, rotten.Length);

        if (Random.value <= 0.5f)
        {
            Instantiate(fruits[randomFruit], new Vector3(Random.Range(-xBounds, xBounds), yBounds, 2f), Quaternion.identity);
        }
        else if (Random.value <= 0.75f)
        {
            Instantiate(rotten[randomRotten], new Vector3(Random.Range(-xBounds, xBounds), yBounds, 2f), Quaternion.identity);
        }
        else
        {
            Instantiate(bomb, new Vector3(Random.Range(-xBounds, xBounds), yBounds, 2f), Quaternion.identity);
        }
        StartCoroutine(SpawnRandomGameObject());
    }
}
