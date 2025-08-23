using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // [SerializeField] private char _upKey;
    // [SerializeField] private char _downKey;
    // [SerializeField] private char _leftKey;
    // [SerializeField] private char _rightKey;
    [SerializeField] private float moveSpeed = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * moveSpeed;
        }
        
        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 5f;
        }
        else
        {
            moveSpeed = 2f;
        }
    }
}
