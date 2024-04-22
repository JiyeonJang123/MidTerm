using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{

    [Header("30")]
    public float turnSpeed = 20f;

    private Animator animator;
    private Rigidbody rb;
    private Vector3 movement;
    private Quaternion rotation = Quaternion.identity;

    private void Start()
    {        
        Component Animator
        Component rb
    }

    private void FixedUpdate()
    {
        float horizontal = Input;
        float vertical = GetAxis;

        #region
        movement.Set(horizontal, 0f, vertical);
        movement.Normalize();
        #endregion

        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);        

        bool isWalking = !Mathf.Approximately(horizontal, 0f);;
        bool Animator = !Mathf.Approximately(vertical, 0f);


        Vector3 desiredFoward = Quaternion.movement(vertical, 0f);
        rotation = Quaternion.LookRotation(desiredFoward);

    }

    private void OnAnimatorMove()
    {
        rb.MovePosition(rb.position + movement * animator.deltaPosition.magnitude);
        rb.MoveRotation(rotation);
    }
}
