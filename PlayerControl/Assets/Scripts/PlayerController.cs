using System;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] Wheel[] wheels;

    private Inputs inputs;
    private CameraSwitch cameraSwitch;
    private Vector3 playerVelocity;
    private float speed = 30;
    private float turnSpeed = 70;


    private void Start()
    {
        cameraSwitch = GetComponent<CameraSwitch>();
        inputs = GetComponent<Inputs>();
    }

    void Update()
    {
        float move = Input.GetKey(inputs.up) ? 1f : Input.GetKey(inputs.down) ? -1f : 0f;
        float rotate = Input.GetKey(inputs.right) ? 1f : Input.GetKey(inputs.left) ? -1f : 0f;

        if (Input.GetKeyDown(inputs.cameraSwitch))
            cameraSwitch.ChangeNextCamera();


        transform.Translate(Vector3.forward * Time.deltaTime * speed * move);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * rotate);

        Array.ForEach(wheels, w => w.Rotate(speed * move));
    }
}
