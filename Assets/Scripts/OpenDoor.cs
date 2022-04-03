using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Transform door;
    private bool _doorOpen = false;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_doorOpen == false)
            {
                _doorOpen = true;
                door.transform.Rotate(0f, -90f, 0f);
            }
            else
            {
                _doorOpen=false;
                door.transform.Rotate(0f, 90f, 0f);
            }
        }
    }
}
