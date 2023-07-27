using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    public CharacterController Character;

    public Vector3 Forward;
    public Vector3 Right;



    void Start()
    {

    }


    void Update()
    {

    }

    void FixedUpdate()
    {
        UpdateMovimentation();
    }

    void UpdateMovimentation()
    {
        var _vertical = Input.GetAxis("Vertical");
        var _horizontal = Input.GetAxis("Horizontal");


        var _forward = Forward * _vertical;
        var _right = Right * _horizontal;
        var _moveDirection = (_forward + _right).normalized * MoveSpeed * Time.fixedDeltaTime;

        Character.Move(_moveDirection);
    }
}
