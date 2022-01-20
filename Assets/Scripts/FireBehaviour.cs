using LabyrintheUnity.Player;
using UnityEngine;

namespace LabyrintheUnity
{
	public class FireBehaviour : MonoBehaviour
	{
		private void OnCollisionEnter2D(Collision2D col)
		{
			var wp = col.gameObject.GetComponent<WaterPicker>();
			if (wp == null)
				return;

			if (wp.HasWater)
			{
				Destroy(this.gameObject);
			}
		}
	}
}
