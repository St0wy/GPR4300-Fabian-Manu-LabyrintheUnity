using UnityEngine;

namespace LabyrintheUnity.Player
{
	public class WaterPicker : MonoBehaviour
	{
		public bool HasWater { get; private set; }

		private void OnTriggerEnter2D(Collider2D col)
		{
			// Check if we colided with the water
			if (!col.gameObject.CompareTag("water"))
				return;

			HasWater = true;
			Destroy(col.gameObject);
		}
	}
}
