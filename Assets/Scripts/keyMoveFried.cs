using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyMoveFried : MonoBehaviour
{

    private Rigidbody rb;
    public new Transform camera;
    // public ConfigurableJoint cj;
    //private Transform tf;

    private ConfigurableJoint[] confJointArr = new ConfigurableJoint[4];

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // cj = GetComponent<ConfigurableJoint>();
        //tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (confJointArr[0] == null)
                confJointArr[0] = createConfJointWithAnchor(new Vector3(0f,0f,0f));
            // cj.anchor = new Vector3(0f,0f,0f);
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (confJointArr[1] == null)
                confJointArr[1] = createConfJointWithAnchor(new Vector3(0.5f,0f,0f));
            // cj.anchor = new Vector3(0.5f,0f,0f);
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            if (confJointArr[2] == null)
                confJointArr[2] = createConfJointWithAnchor(new Vector3(-0.25f,0f,-0.43f));
            // cj.anchor = new Vector3(-0.25f,0f,-0.43f);
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            if (confJointArr[3] == null)
                confJointArr[3] = createConfJointWithAnchor(new Vector3(-0.25f,0f,0.43f));
            // cj.anchor = new Vector3(-0.25f,0f,0.43f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Destroy(confJointArr[0]);
            confJointArr[0] = null;
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Destroy(confJointArr[1]);
            confJointArr[1] = null;
        }        
        
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Destroy(confJointArr[2]);
            confJointArr[2] = null;
        }        
        
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            Destroy(confJointArr[3]);
            confJointArr[3] = null;
        }

        if (Input.GetMouseButton(0))
        {
            int verticalFactor = anyJoint() ? 3 : 1;
            float vertical = Input.GetAxis("Mouse Y");
            float horizontal = Input.GetAxis("Mouse X");
            rb.AddForce((Vector3.up + camera.up) * vertical * verticalFactor + camera.right * horizontal * 5);
        }
    }

    ConfigurableJoint createConfJointWithAnchor(Vector3 vector)
    {
        ConfigurableJoint newConfJoint = gameObject.AddComponent<ConfigurableJoint>() as ConfigurableJoint;
        newConfJoint.anchor = vector;
        newConfJoint.xMotion = ConfigurableJointMotion.Locked;
        newConfJoint.yMotion = ConfigurableJointMotion.Locked;
        newConfJoint.zMotion = ConfigurableJointMotion.Locked;
        return newConfJoint;
    }

    bool anyJoint()
    {
        foreach (ConfigurableJoint joint in confJointArr)
        {
            if (joint != null) return true;
        }
        return false;
    }
}
