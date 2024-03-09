using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawner : MonoBehaviour
{
    void OnCollisionEnter(Collision target)
    {
        Destroy(target.gameObject);
    }
}
