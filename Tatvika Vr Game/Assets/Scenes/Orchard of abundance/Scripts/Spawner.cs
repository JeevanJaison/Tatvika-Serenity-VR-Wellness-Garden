using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] fruits;
    public GameObject bomb;
   

    public float xBounds, yBounds;
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));
        int randomFruit = Random.Range(0, fruits.Length);

        if (Random.value <= 0.6f)
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