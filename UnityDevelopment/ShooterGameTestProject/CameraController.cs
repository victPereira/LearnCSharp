using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController Player;

    void Start()
    {
        SetPlayerDirection();
    }

    // Update is called once per framee
    void Update()
    {

    }
    void SetPlayerDirection()
    {
        var _forward = transform.forward;
        var _right = transform.right;

        _forward = Vector3.ProjectOnPlane(_forward, Vector3.up);

        Player.Forward = _forward;
        Player.Right = _right;
    }
}
