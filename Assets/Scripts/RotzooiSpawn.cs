using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotzooiSpawn : MonoBehaviour
{
    private float spawnCd;

    [SerializeField]
    Transform spawnPart;
    [SerializeField]
    List<GameObject> items = new List<GameObject>();
    [SerializeField]
    GameObject aarde;

    private bool spawned = false;
    void Start()
    {
        spawnCd = Random.Range(5, 8);
    }

    void Spawn()
    {
        GameObject item = items[Random.Range(0, items.Count)];
        GameObject b = Instantiate(item, spawnPart.position, spawnPart.rotation);
        b.transform.parent = aarde.transform;
        spawned = false;
    }

    void FixedUpdate()
    {
        if (spawnCd <= 0 && !spawned)
        {
            spawned = true;
            spawnCd = Random.Range(5, 8);
            Spawn();
        }
        spawnCd -= 1 * Time.deltaTime;
    }
}
