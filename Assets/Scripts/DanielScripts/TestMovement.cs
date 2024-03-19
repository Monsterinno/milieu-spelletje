using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.localPosition += transform.TransformDirection(new Vector3(0, 0, 5) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.localPosition += transform.TransformDirection(new Vector3(0, 0, -5) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.localPosition += transform.TransformDirection(new Vector3(5, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.localPosition += transform.TransformDirection(new Vector3(-5, 0, 0) * Time.deltaTime);
        }  
    }
}
