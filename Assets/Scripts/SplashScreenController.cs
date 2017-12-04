using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenController : MonoBehaviour 
{
	void Start () 
    {
		
	}
	
	void Update () 
    {
        if (Input.GetKeyDown("return")) {
            SceneManager.LoadScene("Level001");
        }

        if (Input.GetKeyDown("escape")) {
            Application.Quit();
        }
	}
}
