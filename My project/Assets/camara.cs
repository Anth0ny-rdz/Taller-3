using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
	public Transform target; // Objeto que la c�mara seguir�
	public Vector3 offset; // Offset de la c�mara con respecto al objeto

	void LateUpdate()
	{
		if (target != null)
		{
			// Calcular la posici�n deseada de la c�mara
			Vector3 desiredPosition = target.position + offset;

			// Asignar la posici�n deseada a la posici�n de la c�mara
			transform.position = desiredPosition;

			// Mantener la rotaci�n original de la c�mara
			transform.rotation = Quaternion.Euler(0, target.eulerAngles.y, 0);
		}
	}
}