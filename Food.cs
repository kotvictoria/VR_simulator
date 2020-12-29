using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float speed = 0.1f;
    public float rotationSpeed = 0.1f;
    public Transform target;
    public bool directionUp = true;
    public float startPosY = 0f;
    public float maxDist = 1f;

    private void Start() {
        startPosY = transform.position.y;
    }
    

    // Update is called once per frame
    void Update(){
        Vector3 direction;
        if (directionUp == true)
            direction = speed * Vector3.up;
        else
            direction = speed * Vector3.up * -1;
        transform.Translate(direction);
        transform.Rotate(Vector3.up * rotationSpeed);
        if (transform.position.y > startPosY + maxDist || transform.position.y < startPosY){
            directionUp = !directionUp;

        }


        
    }
}
