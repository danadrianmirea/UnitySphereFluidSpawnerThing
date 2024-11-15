using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomScaleScript : MonoBehaviour
{
    public float growAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Grow()
    {
        transform.position += Vector3.up * growAmount / 2;   // Move the object in the direction of scaling, so that the corner on ther side stays in place
        transform.localScale += Vector3.up * growAmount;     // Scale object in the specified direction
    }

    // Update is called once per frame
    void Update()
    {
    }
}
