using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    public static QuitScript instance;
    public void Awake()
    {
        instance = this;
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
