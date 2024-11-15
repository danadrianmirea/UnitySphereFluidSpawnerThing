using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGravity : MonoBehaviour
{
    // Start is called before the first frame update
    public float gravity;
    private Rigidbody r;

    void Start()
    {
        r = GetComponent<Rigidbody>();
        r.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = r.velocity;
        v += new Vector3(0.0f, gravity, 0.0f);
        r.velocity = v;
    }
}
