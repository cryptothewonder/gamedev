using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xWall = 10;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xWall)
        {
            transform.position = new Vector3(-xWall,transform.position.y,transform.position.z);
        } else if (transform.position.x > xWall)
        {
            transform.position = new Vector3(xWall,transform.position.y,transform.position.z);
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right *horizontalInput * speed * Time.deltaTime);
        
        if(Input.GetKeyDown(KeyCode.Space)){
            //launch projectile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
