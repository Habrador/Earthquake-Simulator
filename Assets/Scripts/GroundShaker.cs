using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundShaker : MonoBehaviour
{
    //How string is the earthquake?
    public float magnitude = 4f;
    public float slowDownFactor = 0.01f;

    private Vector3 originalPosition;



    void Start()
    {
        originalPosition = transform.position;    
    }

    
	
    void FixedUpdate()
    {
        //Shake the ground with some random values
        Vector2 randomPos = Random.insideUnitCircle * magnitude;
        
        //Will generate a more realistic earthquake 
        float randomX = Mathf.Lerp(transform.position.x, randomPos.x, Time.fixedTime * slowDownFactor);
        float randomZ = Mathf.Lerp(transform.position.z, randomPos.y, Time.fixedTime * slowDownFactor);

        Vector3 moveVec = new Vector3(randomX, originalPosition.y, randomZ);

        transform.position = originalPosition + moveVec;
    }
}
