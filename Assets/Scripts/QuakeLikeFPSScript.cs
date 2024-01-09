using System;
using UnityEngine;

public class QuakeLikeFPSScript : MonoBehaviour
{
    public Transform bodyTransform;
    public Transform cameraTransform;
    public Rigidbody playerRigidBody;
    public float speed;
    public float yawRotationSpeed;
    public float pitchRotationSpeed;

    private Vector3 directionIntent;
    private bool wantToJump;
    public static int hp;
    private GameObject Heart1;
    private GameObject Heart2;
    private GameObject Heart3;
    private void Start()
    {
        Heart1 = GameObject.Find("Heart1");
        Heart2 = GameObject.Find("Heart2");
        Heart3 = GameObject.Find("Heart3");
        Cursor.lockState = CursorLockMode.Locked;
        hp = 3;
        cameraTransform.rotation =
            Quaternion.Euler(new Vector3(
                0, 0, 0
            ));
    }

    // Update is called once per frame
    private void Update()
    {
        if (hp >= 1) {
            Heart1.SetActive(true);
        } else {
            Heart1.SetActive(false);
        } 
        if (hp >= 2) {
            Heart2.SetActive(true);
        } else {
            Heart2.SetActive(false);
        }
        if (hp >= 3) {
            Heart3.SetActive(true);
        } else {
            Heart3.SetActive(false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            directionIntent += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            directionIntent += Vector3.back;
        }

        if (Input.GetKey(KeyCode.A))
        {
            directionIntent += Vector3.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            directionIntent += Vector3.right;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10f;
        }
        else
        {
            speed = 5f;
        }

        var mouseXDelta = Input.GetAxis("Mouse X");

        bodyTransform.Rotate(Vector3.up, Time.deltaTime * yawRotationSpeed * mouseXDelta);

        var mouseYDelta = Input.GetAxis("Mouse Y");

        var rotation = cameraTransform.localRotation;

        var rotationX = rotation.eulerAngles.x;

        rotationX += -Time.deltaTime * pitchRotationSpeed * mouseYDelta;
        

        var unClampedRotationX = rotationX;

        if (unClampedRotationX >= 180)
        {
            unClampedRotationX -= 360;
        }

        var clampedRotationX = Mathf.Clamp(unClampedRotationX, -60, 60);

        cameraTransform.localRotation =
            Quaternion.Euler(new Vector3(
                clampedRotationX,
                rotation.eulerAngles.y,
                rotation.eulerAngles.z
            ));

        if (Input.GetKeyDown(KeyCode.Space) &&
            Physics.SphereCast(bodyTransform.position + Vector3.up * (0.1f + 0.45f), 0.45f, Vector3.down, 
                out var _hitInfo, 
                    0.11f)
            )
        {
            wantToJump = true;
        }
    }

    private void FixedUpdate()
    {
        var normalizedDirection = directionIntent.normalized;
        bodyTransform.position += bodyTransform.rotation * normalizedDirection * (Time.deltaTime * speed);
        directionIntent = Vector3.zero;
        
        if (wantToJump)
        {
            playerRigidBody.AddForce(
                Vector3.up * 10f, ForceMode.VelocityChange
                );
            wantToJump = false;
        }
    }
}