using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float rotationY = 0;
    public float mouseSensitivity = 1;
    public float viewRange = 90f;
    public Transform camera;
        
    
    

    // Update is called once per frame
    void Update()
    {
        float rotationX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotationX, 0);

        rotationY -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotationY = Mathf.Clamp(rotationY, -viewRange, viewRange);
        camera.localEulerAngles = new Vector3(rotationY, 0, 0);

        //Vector3 mouse = Input.mousePosition;
        //float angleX = (mouse.x - Screen.width / 2) / Screen.width;
        //float angleY = (mouse.y - Screen.height / 2) / Screen.height;
        //transform.RotateAround(cameraTransform.position, transform.up, angleX);
        //cameraTransform.RotateAround(cameraTransform.position, cameraTransform.right, -angleY);


    }
}
