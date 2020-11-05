using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	public void PlayTheGame()
	{
		SceneManager.LoadScene(sceneManager.GetActiveScene().buildIndex + 1);

	}

	public void QuitTheGame()
	{
	
	}
}
