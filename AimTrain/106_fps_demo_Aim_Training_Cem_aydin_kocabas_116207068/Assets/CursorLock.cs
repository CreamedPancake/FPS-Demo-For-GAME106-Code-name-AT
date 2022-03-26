using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    //Hocam Nedense Cursor visibility ve Cursor lockState benim bilgisayarımda çalışmadı Windows 11den dolayı olabilir. 
    void Update()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
