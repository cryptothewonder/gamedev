using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float upperBounds = 35.0f;
    public float lowerBounds = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > upperBounds){
            Destroy(gameObject);
        } else if (transform.position.z < -10){
            Destroy(gameObject);
        }
    }
}
