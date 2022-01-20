using System;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace LabyrintheUnity.Player
{
	public class KeyPicker : MonoBehaviour
	{
		private bool hasKey = false;
		[SerializeField] private Tile tileToSet;
		[SerializeField] private Tilemap tilemap;
		[SerializeField] private Vector3Int[] tilesToChange;

		public bool HasKey => hasKey;

		private void OnTriggerEnter2D(Collider2D col)
		{
			// Check if we colided with a key
			if (!col.gameObject.CompareTag("key"))
				return;

			Destroy(col.gameObject);
			hasKey = true;

			foreach (Vector3Int tilePos in tilesToChange)
			{
				tilemap.SetTile(tilePos, tileToSet);
			}
		}
	}
}
