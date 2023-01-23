using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject enemy;

    int x_axis;
    private Vector3 SpawnRange;

    float freq = 2f;
    //start
    void Start()
    {
        InvokeRepeating("spawner", 0.5f, freq);
        

    }

    //update
    void Update()
    {
        //random x axis value to spawn 
        x_axis = Random.Range(-15, 15);
        
        if (gameObject.name == "up")
        {
            SpawnRange = new Vector3(x_axis, 1, -17);
        }

        
     
    }

    void spawner()
    {
        Instantiate(enemy, SpawnRange, Quaternion.identity);
    }
}
