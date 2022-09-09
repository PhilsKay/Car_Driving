using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class playerControl : MonoBehaviour
{

    public float speed = 10.0f;
    private float turnSpeed = 25;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        if(forwardInput != 0)
        {
            //move the vehicle left/right
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }

    }
}
