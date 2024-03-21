using System.Collections;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject[] fruits;
    public GameObject bomb;

    public float xBounds, yBounds, minDuration, maxDuration;
    public float fallSpeed =0.1f; 

    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minDuration, maxDuration));

            int randomFruit = Random.Range(0, fruits.Length);
            Vector3 spawnPosition = new Vector3(Random.Range(-xBounds, xBounds), yBounds, 2f);

            if (Random.value <=0.6f)
            {
                GameObject newObject = Instantiate(fruits[randomFruit], spawnPosition, Quaternion.identity);
                StartCoroutine(MoveObjectDown(newObject));
            }
            else
            {
                GameObject newObject = Instantiate(bomb, spawnPosition, Quaternion.identity);
                StartCoroutine(MoveObjectDown(newObject));
            }
        }
    }

    IEnumerator MoveObjectDown(GameObject obj)
    {
        while (obj != null && obj.transform.position.y > -yBounds)
        {
            obj.transform.Translate(Vector3.down * Time.deltaTime * fallSpeed, Space.World);
            yield return null;
        }

        if (obj != null)
        {
            Destroy(obj);
        }
    }
}
