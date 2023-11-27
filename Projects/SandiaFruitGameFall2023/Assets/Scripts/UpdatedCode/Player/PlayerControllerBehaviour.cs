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

        float playerRadius = .7f;
        float playerHeight = 2f;
        float moveDistance = moveSpeed * Time.deltaTime;
        bool canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDir, moveDistance);
        
        if (!canMove)
        {
            Vector3 moveDirX = new Vector3(moveDir.x, 0, 0);
            
            canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDirX, moveDistance);

            if (canMove)
            {
                moveDir = moveDirX;
            }
            else
            {
                Vector3 moveDirZ = new Vector3(0, 0, moveDir.z);
            
                canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDirZ, moveDistance);
                if (canMove)
                {
                    moveDir = moveDirZ;
                }
            }
        }
        
        if (canMove)
        {
            transform.position += moveDir * moveDistance;
        }

        float rotateSpeed = 10f;

        transform.forward = Vector3.Slerp(transform.forward,moveDir, Time.deltaTime * rotateSpeed);
    }
    
}
