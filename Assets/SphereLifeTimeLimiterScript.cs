using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereLifeTimeLimiterScript : MonoBehaviour
{

    public float sphereLifeTime;
    private float lifeTimeElapsed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        lifeTimeElapsed += Time.deltaTime;
        if(lifeTimeElapsed > sphereLifeTime)
        {
            Destroy(this.gameObject);
            GameObject pool = GameObject.FindWithTag("PoolOfShit");
            if (pool)
            {
                pool.GetComponent<CustomScaleScript>().Grow();
            }

            // Destroy(this.gameObject.GetComponent<CustomGravity>());
            //Destroy(this.gameObject.GetComponent<Rigidbody>());
        }
    }
}
