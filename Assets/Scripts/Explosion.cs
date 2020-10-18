using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject[] cubes;

    public Vector3 newRandPos, finalRandPos;

    public float randPartX, randPartY, randPartZ;

    public Wall wall;

    public GameObject cubeToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        wall = GameObject.FindWithTag("wall").GetComponent<Wall>();
        if (wall != null)
        {
            Debug.Log(randPartX = wall.newPos());
            
            //

            Debug.Log("this does exist ");
        }



        for (int i = 0; i < cubes.Length; i++)
        {
            randPartX = wall.newPos();
            randPartY = 3f;//Random.Range(2.0f, 4.5f);
            randPartZ = 30f;
             cubes[i].transform.position = new Vector3(randPartX, randPartY, randPartZ);

            cubeToDestroy = cubes[i];
            Destroy(cubeToDestroy, 1f);
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    
}

