using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;
    private float xInput;
    private float zInput;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        processInputs();
    }
    private void FixedUpdate()
    {
        move();
    }
    private void processInputs()
    {
       xInput = Input.GetAxis("Horizontal");
       zInput = Input.GetAxis("Vertical");
    }
    private void move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
    }
}
