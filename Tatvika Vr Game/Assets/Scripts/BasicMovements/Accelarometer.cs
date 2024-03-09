using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using Unity.VisualScripting;
using UnityEngine;

public class Accelarometer : MonoBehaviour
{

    private Rigidbody rigid;
    public bool flat = true;
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Vector3 move = Input.acceleration;
        if (flat)
            move = Quaternion.Euler(90, 0, 180) * move;
        rigid.AddForce(move);
        Debug.Log("Raw Acceleration: " + Input.acceleration);
        Debug.Log("Adjusted Acceleration: " + move);
    }



}