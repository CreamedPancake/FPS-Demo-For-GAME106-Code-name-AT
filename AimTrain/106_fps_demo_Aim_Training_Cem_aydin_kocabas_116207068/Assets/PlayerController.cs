using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform cameraHolder;
    [SerializeField] float Sensitivity = 1;
    
    float verticalLookRotation;

    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * Sensitivity);
        verticalLookRotation -= Input.GetAxisRaw("Mouse Y") * Sensitivity;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        cameraHolder.localEulerAngles = new Vector3(verticalLookRotation, 0, 0);
    }
}
