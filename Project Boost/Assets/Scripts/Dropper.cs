using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    public float waitTime = 15f;

    Rigidbody rb;

    MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        mr = GetComponent<MeshRenderer>();

        rb.useGravity = false;

        mr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > waitTime)
        {
            rb.useGravity = true;
            mr.enabled = true;
        }
    }
}
