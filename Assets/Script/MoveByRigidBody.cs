using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByRigidBody : MonoBehaviour
{
   
    [SerializeField]
    private float SpeedFactor = 10f;
    public FixedJoystick joystick;
    
    private Rigidbody2D Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        Rb.velocity = new Vector3(horizontal, vertical, 0f) * SpeedFactor;
    }
}
