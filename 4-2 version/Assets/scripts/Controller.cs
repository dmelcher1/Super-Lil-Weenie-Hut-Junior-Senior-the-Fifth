using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

	CharacterController player1;
	CharacterController player2;

	public float speed;
	public Vector3 player1Position = new Vector3 (0, 0, 0);
	public Vector3 player2Position = new Vector3 (0, 0, 0);

	private Rigidbody rb;


	void Start()
	{
		rb = GetComponent<Rigidbody>();
		player1 = GameObject.FindGameObjectWithTag ("Player1").GetComponent<CharacterController> ();
		player2 = GameObject.FindGameObjectWithTag ("Player2").GetComponent<CharacterController> ();
	}


	void FixedUpdate()
	{
		if (this.gameObject.tag == "Player1")
		{
			if (Input.GetKey ("w") || Input.GetKey ("a") || Input.GetKey ("s") || Input.GetKey ("d"))
			{
				float moveHorizontal = Input.GetAxis ("Player1_Horizontal");
				float moveVertical = Input.GetAxis ("Player1_Vertical");

				Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

				rb.AddForce (movement * speed);

			}
	
		}
		if (this.gameObject.tag == "Player2")
		{
			if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.RightArrow))
			{
				float moveHorizontal = Input.GetAxis ("Player2_Horizontal");
				float moveVertical = Input.GetAxis ("Player2_Vertical");

				Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

				rb.AddForce (movement * speed);

			}

		}

	}
		
}