using UnityEngine;

namespace LabyrintheUnity.Player
{
	[RequireComponent(typeof(PlayerInputBehaviour))]
	[RequireComponent(typeof(Rigidbody2D))]
	[RequireComponent(typeof(Animator))]
	public class PlayerMovement : MonoBehaviour
	{
		private static readonly int IsMoving = Animator.StringToHash("IsMoving");

		private PlayerInputBehaviour playerInput;
		private Animator animator;
		private Rigidbody2D rb;

		[SerializeField] private float movementSpeed = 1f;

		private void Awake()
		{
			playerInput = GetComponent<PlayerInputBehaviour>();
			rb = GetComponent<Rigidbody2D>();
			animator = GetComponent<Animator>();
		}

		private void Update()
		{
			animator.SetBool(IsMoving, rb.velocity != Vector2.zero);
		}

		private void FixedUpdate()
		{
			// Apply movement
			rb.velocity = playerInput.Movement * (movementSpeed * Time.deltaTime);
		}
	}
}
