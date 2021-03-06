﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const string groundTag = "Ground";
    private const float horizontalSpeed = 150;
    private const int verticalSpeed = 400;

    [SerializeField]
    private Rigidbody rigidbody;

    private bool dazed = false;
    private bool isGrounded;
    private bool isJumpActionCalled;

    private void Awake()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
    }

    private void Start()
    {

    }

    private void OnDisable()
    {

    }

    private void OnDestroy()
    {

    }

    private void Update()
    {
        HandleGetKeyDownInput();
    }

    private void FixedUpdate()
    {
        HandleMovementFromInput();
    }

    private void HandleGetKeyDownInput()
    {
        if (!dazed)
        {
            if (Input.GetKeyDown(KeyCode.W) && isGrounded)
            {
                isJumpActionCalled = true;
                isGrounded = false;
            }
        }
    }

    private void HandleMovementFromInput()
    {
        if (!dazed)
        {
            if (Input.GetKey(KeyCode.D))
            {
                //rigidbody.velocity = Vector3.right * 100 * Time.deltaTime;
                rigidbody.velocity = new Vector3(horizontalSpeed * Time.deltaTime, rigidbody.velocity.y);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rigidbody.velocity = new Vector3(-horizontalSpeed * Time.deltaTime, rigidbody.velocity.y);
            }
            if (isJumpActionCalled)
            {
                rigidbody.velocity = new Vector3(rigidbody.velocity.x, verticalSpeed * Time.deltaTime);
                isJumpActionCalled = false;
            }
        }
    }

    public void ThrowBack(Vector3 directon, float throwBackForce)
    {
        dazed = true;
        rigidbody.velocity = directon * throwBackForce;
    }

    private void LateUpdate()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(groundTag))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {

    }

    private void OnCollisionExit(Collision collision)
    {

    }
}
