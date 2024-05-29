using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerTransform;
    public float x = 1;
    public float y = 23.5f;
    public float z = -10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3( PlayerTransform.position.x + x, PlayerTransform.position.y + y, PlayerTransform.position.z + z);  
        
    }
}
