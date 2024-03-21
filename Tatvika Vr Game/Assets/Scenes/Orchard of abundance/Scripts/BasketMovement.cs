using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    private float mFactor;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        mFactor = 4f;
        offset = new Vector3(mFactor * Time.deltaTime, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= -3.5)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= offset;
            }
        }
        if (transform.position.x <= 3.5)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += offset;
            }
        }
    }
}
