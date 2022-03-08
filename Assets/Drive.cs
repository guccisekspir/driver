using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 50;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, -steerAmount);

    }
}
