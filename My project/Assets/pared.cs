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
			// Aquí puedes agregar código para manejar la colisión con el jugador,
			// como detener su movimiento o causar algún efecto.
		}
	}
}
