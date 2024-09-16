using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecameras : MonoBehaviour
{
    [SerializeField] public GameObject[] cameracontroller;
      private int currentCameraIndex = 0;
    void Start()
    {

        
    }

 
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            cameracontroller[currentCameraIndex].SetActive(false);
            currentCameraIndex = (currentCameraIndex + 1) % cameracontroller.Length;
            cameracontroller[currentCameraIndex].SetActive(true);
        }
}
}