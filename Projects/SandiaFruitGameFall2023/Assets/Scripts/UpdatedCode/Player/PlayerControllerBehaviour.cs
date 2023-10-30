using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBehaviour : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private GameInput gameInput;
    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);

        float playerSize = 7f;
        bool canMove = !Physics.Raycast(transform.position, moveDir, playerSize);
        if (canMove)
        {
            transform.position += moveDir * moveSpeed * Time.deltaTime;
        }

        float rotateSpeed = 10f;

        transform.forward = Vector3.Slerp(transform.forward,moveDir, Time.deltaTime * rotateSpeed);
    }
}
