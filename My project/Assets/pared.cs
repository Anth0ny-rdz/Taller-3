using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pared : MonoBehaviour
{
	// Start is called before the first frame update
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			// Aqu� puedes agregar c�digo para manejar la colisi�n con el jugador,
			// como detener su movimiento o causar alg�n efecto.
		}
	}
}
