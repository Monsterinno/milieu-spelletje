using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTemp : MonoBehaviour
{
    public float Temp = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Temp += Time.deltaTime;
        Debug.Log(Temp);
    }
}
