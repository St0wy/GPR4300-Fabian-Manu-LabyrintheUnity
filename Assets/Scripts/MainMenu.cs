using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LabyrintheUnity
{
	public class MainMenu : MonoBehaviour
	{
		[UsedImplicitly]
		public void LoadLabyrinthScene()
		{
			SceneManager.LoadScene(1);
		}

		[UsedImplicitly]
		public void QuitApplication()
		{
			Application.Quit();
		}
	}
}
