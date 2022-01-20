using UnityEngine;

namespace LabyrintheUnity
{
	public class TeleporterBehaviour : MonoBehaviour
	{
		[SerializeField] private Transform end;

		private void OnTriggerEnter2D(Collider2D col)
		{
			var rb = col.GetComponent<Rigidbody2D>();
			if (rb == null)
			{
				return;
			}

			rb.Sleep();
			rb.position = end.position;
			rb.WakeUp();
		}
	}
}
