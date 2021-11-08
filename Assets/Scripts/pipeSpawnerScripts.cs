using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScripts : MonoBehaviour
{
    public float MaxTime = 1;
    private float timer = 0;
    public GameObject pipa;
    public float height;
    
    void Start()
    {
        GameObject newpipe = Instantiate(pipa);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update()
    {
        if(timer > MaxTime)
        {
            GameObject newpipe = Instantiate(pipa);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
