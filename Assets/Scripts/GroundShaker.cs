using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundShaker : MonoBehaviour
{
    //How strong is the earthquake?
    public float magnitude = 4f; //Not the same magnitude people talk about in an actual earthquakes
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

        float randomY = Random.Range(-1f, 1f) * magnitude;

        //Will generate a more realistic earthquake - otherwise the ground will jitter and not shake
        float randomX = Mathf.Lerp(transform.position.x, randomPos.x, Time.fixedTime * slowDownFactor);
        float randomZ = Mathf.Lerp(transform.position.z, randomPos.y, Time.fixedTime * slowDownFactor);

        randomY = Mathf.Lerp(transform.position.y, randomY, Time.fixedTime * slowDownFactor * 0.1f);
        
        Vector3 moveVec = new Vector3(randomX, randomY, randomZ);

        transform.position = originalPosition + moveVec;
    }
}
