using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner7 : MonoBehaviour
{
    public GameObject[] fruits;
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

        if (Random.value <= 0.9f)
        {
            Instantiate(fruits[randomFruit], new Vector3(Random.Range(-xBounds, xBounds), yBounds, 2f), Quaternion.identity);
        }
        else
        {
            Instantiate(bomb, new Vector3(Random.Range(-xBounds, xBounds), yBounds, 2f), Quaternion.identity);
        }
        StartCoroutine(SpawnRandomGameObject());
    }
}
