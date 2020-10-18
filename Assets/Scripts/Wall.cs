using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject explosionPrefab;

    public Vector3 newPosition;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "bullet")
        {
            Debug.Log("bullet has hit the wall");
            // get the position of the bullet. 
      

            newPosition = other.collider.transform.position;

            Debug.Log(newPosition);

            Instantiate(explosionPrefab,newPosition,Quaternion.identity);
            
        }
    }
}



