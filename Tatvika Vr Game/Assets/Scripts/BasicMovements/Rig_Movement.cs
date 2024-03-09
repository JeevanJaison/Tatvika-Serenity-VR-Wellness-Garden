using UnityEngine;

public class Rig_Movement : MonoBehaviour
{
    Vector3 ns = new Vector3(0.0f, 0.0f, 0.05f);
    Vector3 ew = new Vector3(0.05f, 0.0f, 0.0f);
    public float movementSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.gyro.attitude);
        //Vector3 gyroInput = Input.gyro.attitude.eulerAngles;
        //float w = gyroInput.y * movementSpeed; 
        //float d = gyroInput.x * movementSpeed;
        float w = Input.gyro.attitude.y;
        float d = Input.gyro.attitude.x;

        if (d > 0.1f && w > 0.1f)             //Move right + +
        {
            transform.position = transform.position + ew * movementSpeed;
        }
        else if (d < -0.1f && w < -0.1f)   //Move left - -
        {
            transform.position = transform.position - ew * movementSpeed;
        }
        else if (d > 0.1f && w < -0.1f)  //Move down + -
        {
            transform.position = transform.position - ns * movementSpeed;
        }
        else if (d < -0.1f && w > 0.1f)  //Move up - +
        {
            transform.position = transform.position + ns * movementSpeed;
        }
        //Vector3 newPosition = cube.transform.position;
        //newPosition.x += w * Time.deltaTime; 
        //cube.MovePosition(newPosition); 
    }
}
