using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private float speed = 5f;

    void Start()
    {
        // Hata: "GetCompenent" yazılmış, doğrusu "GetComponent"
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        // Hata: "Input GetAxis" yazılmış, doğrusu "Input.GetAxis"
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movementVector = new Vector3(horizontal, 0, vertical);
        movementVector = Vector3.ClampMagnitude(movementVector, 1);

        Vector3 movement = movementVector * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);

       
        
    }
}

