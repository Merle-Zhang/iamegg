using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{

    public Transform PlayerTransform;
    public Transform PlayerTransformFrid;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;


    public float RotationsSpeed = 5.0f;

    // Use this for initialization
    void Start()
    {
        _cameraOffset = transform.position - PlayerTransform.position;
    }

    // LateUpdate is called after Update methods
    void LateUpdate()
    {
        if (PlayerTransform != PlayerTransformFrid && PlayerTransform.gameObject.activeSelf == false)
        {
            PlayerTransform = PlayerTransformFrid;
        }
        if (Input.GetMouseButton(1))
        {
            Quaternion camTurnAngle =
            //    Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationsSpeed, Vector3.up);
            Quaternion.Euler(Input.GetAxis("Mouse Y") * RotationsSpeed, Input.GetAxis("Mouse X") * RotationsSpeed, 0);

            _cameraOffset = camTurnAngle * _cameraOffset;
        }

        Vector3 newPos = PlayerTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        transform.LookAt(PlayerTransform);
            
    }
}
