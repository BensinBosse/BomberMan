using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{


    //movespeed, rigidbody, vector3 

    public float moveSpeed = 5f;
    public Rigidbody playerRigidbody;
    public Vector3 MovePosition;
    public CharacterController controller;
    public GameObject bomb;

    //referera till rigidbody
    public void Start()
    {

    }

    //ta inputs
    public void Update()
    {

        MovePosition = Vector3.zero;
        MovePosition.z = Input.GetAxisRaw("Vertical");
        MovePosition.x = Input.GetAxisRaw("Horizontal");
        controller.Move(MovePosition * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
            DropBomb();
        }


    }

    void DropBomb()
    {
        Instantiate(bomb, this.gameObject.transform.position, Quaternion.identity);
    }

}