using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace LabyrintheUnity
{
	public class WinDetector : MonoBehaviour
	{
		private void OnCollisionEnter2D(Collision2D col)
		{
			if (col.gameObject.GetComponent<PlayerInput>() != null)
			{
				// Load the wining scene if we collide with the player
				SceneManager.LoadScene(2);
			}
		}
	}
}
