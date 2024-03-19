using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public float effect;
    public GameObject planet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && this.gameObject.tag == "GoodItem")
        {
            Debug.Log("1: "+planet.GetComponent<TestTemp>().Temp);
            planet.GetComponent<TestTemp>().Temp = planet.GetComponent<TestTemp>().Temp - effect;
            Debug.Log("2: "+planet.GetComponent<TestTemp>().Temp);
            Destroy(this.gameObject);
        }

        else if (other.gameObject.tag == "Player" && this.gameObject.tag == "BadItem")
        {
            Debug.Log("1: "+planet.GetComponent<TestTemp>().Temp);
            planet.GetComponent<TestTemp>().Temp = planet.GetComponent<TestTemp>().Temp + effect;
            Debug.Log("2: "+planet.GetComponent<TestTemp>().Temp);
            Destroy(this.gameObject);
        }

        else
        {
            return;
        }
    }
}
