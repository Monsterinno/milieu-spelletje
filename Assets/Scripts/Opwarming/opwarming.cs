using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opwarming : MonoBehaviour
{
    public float Temperatuur;
    public float TemperatuurSpeed;
    public float TempDrempelwaarde1;
    public float TempDrempelwaarde2;
    public float TempDrempelwaarde3;
    public float TempDrempelwaarde4;
    public Color blue;
    public Color red;
    public Color yellow;
    public Color orange;

    private Renderer earthRenderer;
    // Start is called before the first frame update
    void Start()
    {
        earthRenderer = GetComponent<MeshRenderer>();
        earthRenderer.material.color = blue;
    }

    // Update is called once per frame
    void Update()
    {
        Temperatuurstijging();
        CheckTemperatuur();
    }

    void Temperatuurstijging()
    {
        Temperatuur += TemperatuurSpeed * Time.deltaTime;
    }

    void CheckTemperatuur()
    {
        if (Temperatuur >= TempDrempelwaarde1)
        {
            earthRenderer.material.color = blue;
        }

        if (Temperatuur >= TempDrempelwaarde2)
        {
            earthRenderer.material.color = yellow;
        }

        if (Temperatuur >= TempDrempelwaarde3)
        {
            earthRenderer.material.color = orange;
        }

        if (Temperatuur >= TempDrempelwaarde4)
        {
            earthRenderer.material.color = red;
        }
    }
}
