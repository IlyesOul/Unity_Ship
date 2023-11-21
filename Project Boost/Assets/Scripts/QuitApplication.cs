using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    void Update()
    {
        testQuit();
    }

    public static void testQuit()
    {
        if(Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
    }
}
