using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float randX, randY, randZ;

    public Vector3 randPos, randPosW;

    public GameObject bulletPrefab;

    private GameObject bulletToDie;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown("space"))
        {
            randPosW = RandPos();
           bulletToDie = Instantiate(bulletPrefab, randPosW, Quaternion.identity);

        }

        Vector3 RandPos()
        {
            randX = Random.Range(-4f, 4f);
            randY = 4.74f;
            randZ = 11f;

            randPos = new Vector3(randX, randY, randZ);

            return randPos;

        }
        Destroy(bulletToDie,.6f);
    }
}

