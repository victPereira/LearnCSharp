using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public float ImpulseForce;
    public Rigidbody2D Rb;

    [Header("Tags")]

    public string ObstacleTag;
    public string ScoreTag;

    [Space]
    public int Score;


    [Header("Events")]

    public UnityEvent OnGameOver;

    private bool _isPressing;

    
    
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _isPressing = Input.GetKey(KeyCode.Mouse0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_isPressing)
        {
            Impulse();
        }
    }

    private void Impulse()
    {
        Rb.AddForce(Vector3.up * ImpulseForce * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(enabled == false)
        {
            return;
        }

        if (other.tag == ObstacleTag)
        {
            enabled = false;
            OnGameOver.Invoke();
        }

        if (other.tag == ScoreTag)
        {
            Score++;
        }
    }

    
}
