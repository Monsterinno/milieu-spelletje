using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotzooiSpawn : MonoBehaviour
{
    public float spawnCd;

    [SerializeField]
    Transform spawnPart;
    [SerializeField]
    List<GameObject> items = new List<GameObject>();
    [SerializeField]
    GameObject aarde;
    
    void Start()
    {
        spawnCd = Random.Range(1, 4);
    }

    void Spawn()
    {
        GameObject item = items[Random.Range(0, items.Count + 1)];
        GameObject b = Instantiate(item, spawnPart.position, spawnPart.rotation);
        b.transform.parent = aarde.transform;
    }

    void Update()
    {
        if (spawnCd == 0)
        {
            Spawn();
            spawnCd = Random.Range(1, 4);
        }
        spawnCd -= 1 * Time.deltaTime;
    }
}
