using System;
using UnityEngine;

namespace LabyrintheUnity.Player
{
	[RequireComponent(typeof(PlayerInputBehaviour))]
	[RequireComponent(typeof(Rigidbody2D))]
	public class PlayerMovement : MonoBehaviour
	{
		private PlayerInputBehaviour playerInput;
		private Rigidbody2D rb;
		[SerializeField] private float movementSpeed = 1f;

		private void Awake()
		{
			playerInput = GetComponent<PlayerInputBehaviour>();
			rb = GetComponent<Rigidbody2D>();
		}

		private void FixedUpdate()
		{
			// Apply movement
			rb.velocity = playerInput.Movement * movementSpeed * Time.deltaTime;
		}
	}
}
