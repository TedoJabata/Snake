using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody snakeRigidBody;

    private void Awake()
    {
        snakeRigidBody = GetComponent<Rigidbody>();
    }

    public void MoveUp()
    {
        Debug.Log("Up!");
        snakeRigidBody.AddForce(Vector3.right * 2f, ForceMode.Force);
    }

    public void MoveLeft()
    {
        Debug.Log("Left!");
        snakeRigidBody.AddForce(Vector3.left * 2f, ForceMode.Force);
    }

    public void MoveDown()
    {
        Debug.Log("Down!");
        snakeRigidBody.AddForce(Vector3.right * 2f, ForceMode.Force);
    }

    public void MoveRight()
    {
        Debug.Log("Right!");
        snakeRigidBody.AddForce(Vector3.right * 2f, ForceMode.Force);
    }
}
