using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decider : MonoBehaviour
{
    MeshRenderer md;

    Rigidbody rb;

    BoxCollider bc;
    // Start is called before the first frame update
    void Start()
    {
        md = GetComponent<MeshRenderer>();

        rb = GetComponent<Rigidbody>();

        bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CollisionHandlerTwo.passLevel == true){
            md.enabled = false;

            bc.enabled = false;
        }
    }
}
