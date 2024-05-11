using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
	public Transform target; // Objeto que la cámara seguirá
	public Vector3 offset; // Offset de la cámara con respecto al objeto

	void LateUpdate()
	{
		if (target != null)
		{
			// Calcular la posición deseada de la cámara
			Vector3 desiredPosition = target.position + offset;

			// Asignar la posición deseada a la posición de la cámara
			transform.position = desiredPosition;

			// Mantener la rotación original de la cámara
			transform.rotation = Quaternion.Euler(0, target.eulerAngles.y, 0);
		}
	}
}