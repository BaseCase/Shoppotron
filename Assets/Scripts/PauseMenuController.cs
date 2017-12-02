using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour 
{
    public GameObject pause_menu;

    private bool paused;
    private float time_scale;

	void Start () 
    {
        paused = false;
        time_scale = Time.timeScale;

	}
	
	void Update () 
    {
        if (Input.GetKeyDown("escape")) {
            if (paused) {
                paused = false;
                Time.timeScale = time_scale;
            } else {
                paused = true;
                Time.timeScale = 0f;
            }
            pause_menu.SetActive(paused);
        }
	}
}
