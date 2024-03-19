using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public int affect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            return;
        }
        else if (collision.gameObject.tag == "Player")
        {
            Debug.Log(collision.gameObject.name);
            Debug.Log(this.gameObject.name + ": " + affect);

        }
    }
}
