using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private string mouseXInput, mouseYInput;
    [SerializeField] private float mouseSensitivity;

    private void Awake()
    {
        LockCursor();
    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxix(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxix(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        transform.Rotate(-transform.right * mouseY);
    }
}


