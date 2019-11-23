using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyMoveBall : MonoBehaviour
{

    public Rigidbody rb;
    public Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        rb.AddForce(camera.forward * vertical * 5 + camera.right * horizontal * 5);
    }
}
