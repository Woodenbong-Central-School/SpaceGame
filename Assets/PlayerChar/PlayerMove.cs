using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 100;
    Rigidbody rb;
    
    
    void Start()

    {
     rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)) 
        {
            rb.AddForce(Vector3.right * Time.deltaTime * speed, ForceMode.VelocityChange);
            transform.localScale = new Vector3(1f, transform.localScale.y, transform.localScale.z);
            //transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * Time.deltaTime * speed, ForceMode.VelocityChange);
            transform.localScale = new Vector3(-1f, transform.localScale.y, transform.localScale.z);
            //transform.position -= Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * Time.deltaTime * speed, ForceMode.VelocityChange);
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, -1f);
            //transform.position += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * Time.deltaTime * speed, ForceMode.VelocityChange);
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 1f);
            //transform.position -= Vector3.forward * Time.deltaTime * speed;
        }
    }
}
