using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    float randomValue;
    void Start()
    {
        randomValue = Random.Range(0.2f, -0.2f);
        transform.position = new Vector2(transform.position.x, randomValue);
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 100, Time.deltaTime * 1);
    }
}
