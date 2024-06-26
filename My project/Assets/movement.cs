using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public float speed = 5.0f; // Velocidad de movimiento

	public float rotaionspeed = 50f;
	void Update()
	{
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");

		Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
		movementDirection.Normalize();

		transform.position = transform.position + movementDirection * speed * Time.deltaTime;
		if (movementDirection != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementDirection), rotaionspeed * Time.deltaTime);

	}
}
