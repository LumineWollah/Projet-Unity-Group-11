using System;
using UnityEngine;

public class DukeNukem3DLikeFPSScript : MonoBehaviour
{
    public Transform cameraTransform;
    public float speed;
    public float yawRotationSpeed;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        var directionIntent = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            directionIntent += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            directionIntent += Vector3.back;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            directionIntent += Vector3.left;
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            directionIntent += Vector3.right;
        }

        var normalizedDirection = directionIntent.normalized;

        cameraTransform.position += cameraTransform.rotation * normalizedDirection * (Time.deltaTime * speed);

        var mouseXDelta = Input.GetAxis("Mouse X");
        
        cameraTransform.Rotate(Vector3.up, Time.deltaTime * yawRotationSpeed * mouseXDelta);
    }
}