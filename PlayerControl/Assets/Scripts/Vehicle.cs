using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] Wheel[] wheels;
    public float speed = 15;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Array.ForEach(wheels, w => w.Rotate(speed));
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}