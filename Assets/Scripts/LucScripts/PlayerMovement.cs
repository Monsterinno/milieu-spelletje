using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public float jumpHeight = 2.0f;
    public float jumpDuration = 0.5f; 
    private bool isJumping = false;
    private Vector3 startPosition;
    private float jumpTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = player.transform.position;
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

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            StartCoroutine(Jump());
        }

        if (isJumping)
        {
            jumpTimer += Time.deltaTime;
            float jumpProgress = jumpTimer / jumpDuration;

            float yOffset = Mathf.Sin(jumpProgress * Mathf.PI) * jumpHeight;

            player.transform.position = startPosition + Vector3.up * yOffset;

            if (jumpTimer >= jumpDuration)
            {
                isJumping = false;
                jumpTimer = 0.0f;
                player.transform.position = startPosition;
            }
        }
        
    }

    IEnumerator Jump()
    {
        isJumping = true;
        yield return null;
    }
}
