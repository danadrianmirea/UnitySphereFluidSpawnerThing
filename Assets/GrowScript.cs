using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float resizeAmount;
    public Vector3 resizeDirection;
    public float resizeInterval;

    private float elapsedTime;

    void Start()
    {
        
    }

    public void Resize(float amount, Vector3 direction)
    {
        transform.position += direction * amount / 2; // Move the object in the direction of scaling, so that the corner on ther side stays in place
        transform.localScale += direction * amount; // Scale object in the specified direction
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime >= resizeInterval)
        {
            elapsedTime = 0.0f;
            Resize(resizeAmount, resizeDirection);
        }
    }
}
