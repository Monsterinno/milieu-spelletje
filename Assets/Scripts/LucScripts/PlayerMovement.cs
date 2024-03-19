using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.rotation = Quaternion.Euler(0, 0, -5);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            player.transform.rotation = Quaternion.Euler(0, 0, 5);
        }
        else
        {
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
