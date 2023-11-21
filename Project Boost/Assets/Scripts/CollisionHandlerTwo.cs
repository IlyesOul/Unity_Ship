using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandlerTwo : MonoBehaviour
{
    public static bool passLevel = false;
    //MeshRenderer md;
     void Start() {
        //md.GetComponent<MeshRenderer>();
    }

    void Update() {
        if(ButtonScript1.bonked1 ==true&&ButtonScript2.bonked2 == true&&ButtonScript3.bonked3 == true&&ButtonScript4.bonked4 == true) 
        {
            passLevel = true;
        }
        
    }
   void OnCollisionEnter(Collision other) {
       if(other.gameObject.tag == "Player")
       {
            GetComponent<MeshRenderer>().material.color = Color.green;
       }
   }
}
