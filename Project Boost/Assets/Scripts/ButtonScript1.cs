using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript1 : MonoBehaviour
{
    public static bool bonked1 = false;

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player")
        {
            bonked1 = true;
        }
    }
}
