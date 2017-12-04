using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreenController : MonoBehaviour 
{
	void Start () 
    {
		
	}
	
	void Update () 
    {
        if (Input.GetKeyDown("escape") || Input.GetKeyDown("return")) {
            Application.Quit();
        }
	}
}
