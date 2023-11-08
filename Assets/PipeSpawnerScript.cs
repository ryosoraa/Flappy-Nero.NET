using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate;
    private float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (spawnDelay < spawnRate)
        {
            spawnDelay += Time.deltaTime;
        } else
        {
            Instantiate(pipe, transform.position, transform.rotation);
            spawnDelay = 0;
        }
    }
}
