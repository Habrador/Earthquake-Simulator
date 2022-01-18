using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundShaker : MonoBehaviour
{
    //How string is the earthquake?
    public float magnitude = 1f;

    private Vector3 originalPosition;



    void Start()
    {
        originalPosition = transform.position;    
    }

    
	
    void FixedUpdate()
    {
        //Shake the ground with some random values
        Vector2 randomPos = Random.insideUnitCircle * magnitude;

        Vector3 moveVec = new Vector3(randomPos.x, originalPosition.y, randomPos.y);

        transform.position = originalPosition + moveVec;
    }
}
