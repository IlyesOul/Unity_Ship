using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript3 : MonoBehaviour
{
    public static bool bonked3 = false;

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player")
        {
            bonked3 = true;
        }
    }
}
