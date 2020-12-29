using UnityEngine;

public class PlayerMove : MonoBehaviour 
{
    public float speed = 10f;
    public Rigidbody rb;
    public Animator animator;
   

    // Update is called once per frame
    void Update()
    {
        // float curRotation = rotationSpeed * Input.GetAxis("Horizontal");
        // transform.Rotate(0, curRotation, 0);
        float curSpeedx = speed * Input.GetAxis("Horizontal");
             
        float curSpeedy = speed * Input.GetAxis("Vertical");
        rb.velocity = transform.forward * curSpeedy * Time.deltaTime + transform.right * curSpeedx * Time.deltaTime;
        if(rb.velocity.magnitude > Mathf.Epsilon)
        {
            animator.SetBool("run", false);
        }
        else
        {
            animator.SetBool("run", true);
        }
        rb.angularVelocity = Vector3.zero;
    }
}
