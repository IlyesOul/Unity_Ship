using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{

    [SerializeField] float yRotateSpeed = 1f;

    [SerializeField] float xRotateSpeed = 1f;

    [SerializeField] float zRotateSpeed = 10f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(xRotateSpeed, yRotateSpeed, zRotateSpeed);
    }
}
