using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LabyrintheUnity
{
	public class WinMenu : MonoBehaviour
	{
		[UsedImplicitly]
		public void GoToMainMenu()
		{
			SceneManager.LoadScene(0);
		}
	}
}
