using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const string groundTag = "Ground";
    private const float horizontalSpeed = 100;
    private const int verticalSpeed = 300;

    [SerializeField]
    private Rigidbody rigidbody;

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

    private void HandleGetKeyDownInput()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            isJumpActionCalled = true;
            isGrounded = false;
        }
    }

    private void FixedUpdate()
    {
        HandleMovementFromInput();
    }

    private void HandleMovementFromInput()
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
