using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    void Update()
    {
        //Press the space bar to apply no locking to the Cursor
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            
             Cursor.lockState = CursorLockMode.Locked;
      
        }

    }

    void OnGUI()
    {
        //Press this button to lock the Cursor
        

        //Press this button to confine the Cursor within the screen
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
