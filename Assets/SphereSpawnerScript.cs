using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    public Vector3 origin;
    public float radius;
    public float spread;
    //public float gravity;

    void Start()
    {
        /*
        for(int i=0; i<5000; i++) { 
            Vector3 randomPosition = origin + Random.insideUnitSphere * radius;
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);

        }
        */
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetMouseButton(0))
        {
            Vector3 randomPosition = origin + Random.insideUnitSphere * radius;
            //Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
            //Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject newShit = Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
            Rigidbody r = newShit.GetComponent<Rigidbody>();
            //  r.gravityScale = 3.0f;
            //r.useGravity = false;
            r.velocity = Random.insideUnitSphere * spread;
            r.velocity = new Vector3(r.velocity.x, 0.0f, r.velocity.z);
            //r.AddForce(new Vector3(0.0f, gravity, 0.0f));
            //r.velocity.z = 0.0f;

            //Vector3 v = new Vector3(1.0f, 2.0f, 3.0f);
            //v.z = 0.0f;

        }
    }
    }
