using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript2 : MonoBehaviour
{
     public static bool bonked2 = false;

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player")
        {
            bonked2 = true;
        }
    }
}
