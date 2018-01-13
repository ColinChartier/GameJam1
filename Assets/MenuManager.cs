using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

	public void doExitGame() {
		Application.Quit ();
	}

	public void LoadScene(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}

}
