using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public  GameObject Sphere;
    public Transform sun;
    public float speed;
    public float selfrotate;
    



    void Start(){
   
    }


    void Update()
    {

    
       transform.RotateAround(sun.transform.position, Vector3.up, speed * Time.deltaTime);
       transform.Rotate (Vector3.up * selfrotate * Time.deltaTime, Space.Self);

       
        

    }
}
