using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject[] cubes;

    public Vector3 newRandPos, finalRandPos;

    public float randPartX, randPartY, randPartZ;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            randPartX = 0f;//Random.Range(-2.0f, 2f);
            randPartY = 5f;//Random.Range(2.0f, 4.5f);
            randPartZ = 30f;

            cubes[i].transform.position = new Vector3(randPartX, randPartY, randPartZ);
        }


    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    
}
