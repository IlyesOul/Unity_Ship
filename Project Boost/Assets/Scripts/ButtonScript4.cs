using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript4 : MonoBehaviour
{
     public static bool bonked4 = false;

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player")
        {
            bonked4 = true;
        }
    }
}
