using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherMover : MonoBehaviour
{
    public float xValue = 0f;
    public float yValue = 1f;
    public float zValue = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(xValue,yValue,zValue);


        if(transform.position.x < -40){
            transform.Translate(xValue,yValue,zValue);
        }

        if(transform.position.x > 49){
            transform.Translate(xValue,-yValue,zValue);
        }
    }
}
