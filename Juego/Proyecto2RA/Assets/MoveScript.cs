using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    public float m_Speed = 12f,AutoAdnvance=0.2f;                 // How fast the tank moves forward and back.
    public float m_TurnSpeed = 180f, AutoTurn=0.2f;            // How fast the tank turns in degrees per second.
    public bool go=false, turnL=false, turnR=false,KeyBoard=false;

    private Rigidbody m_Rigidbody;              // Reference used to move the Character.
    private string m_MovementAxisName;          // The name of the input axis for moving forward and back.
    private string m_TurnAxisName;              // The name of the input axis for turning.
    private float m_MovementInputValue;         // The current value of the movement input.
    private float m_TurnInputValue;             // The current value of the turn input.


    // Use this for initialization
    void Start () {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        m_MovementInputValue = Input.GetAxis("Vertical");
        m_TurnInputValue = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        // Adjust the rigidbodies position and orientation in FixedUpdate.
        Move();
        Turn();
    }

    private void Move()
    {
        if (!KeyBoard)
        {
            // Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
            Vector3 movement = transform.forward * AutoAdnvance * m_Speed * Time.deltaTime;
            if (go)
            {
                // Apply this movement to the rigidbody's position.
                m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
            }
        }
        else
        {
            // Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
            Vector3 movement = transform.forward * m_MovementInputValue * m_Speed * Time.deltaTime;
            m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
        }
    }

    private void Turn()
    {
        if (!KeyBoard)
        {

            // Determine the number of degrees to be turned based on the input, speed and time between frames.
            float turn = AutoTurn * m_TurnSpeed * Time.deltaTime;
            if (turnL)
            {
                // Make this into a rotation in the y axis.
                Quaternion turnRotation = Quaternion.Euler(0f, -turn, 0f);
                // Apply this rotation to the rigidbody's rotation.
                m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation);
            }
            else if (turnR)
            {
                // Make this into a rotation in the y axis.
                Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
                // Apply this rotation to the rigidbody's rotation.
                m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation);
            }
        }
        else
        {
            float turn = m_TurnInputValue * m_TurnSpeed * Time.deltaTime;
            Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
            // Apply this rotation to the rigidbody's rotation.
            m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation);
        }
    }
}
