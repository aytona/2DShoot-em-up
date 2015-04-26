using UnityEngine;
using System.Collections;

public class SceneTransition : MonoBehaviour {

	// Loads the desired scene on click
	public void TransitionToLevel (string levelName)
	{
		Application.LoadLevel(levelName);
	}
}
