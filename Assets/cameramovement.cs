using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    // Start is called before the first frame update
 
     public Vector3 offset = new Vector3(0, 2, -10); // relative Offset to target
      public float smoothSpeed = 0.225f;
     public  GameObject Sphere;
    public Transform Earth;

    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
      Vector3 desiredPosition = Earth.position + offset;
       Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime); 
       transform.position = smoothedPosition; 
       transform.LookAt(Earth);
    
    }
}
