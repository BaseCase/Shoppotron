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
            Debug.Log("heyo");
            SceneManager.LoadScene("Level001");
        }
	}
}
