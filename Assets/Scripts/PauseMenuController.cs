using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenuController : MonoBehaviour 
{
    public GameObject pause_menu;
    public Text restart_option;
    public Text exit_option;

    private bool paused;
    private float time_scale;
    private Text selected;
    private Vector4 white;
    private Vector4 red;

	void Start () 
    {
        paused = false;
        time_scale = Time.timeScale;
        selected = restart_option;
        white = new Vector4(1f, 1f, 1f, 1f);
        red = new Vector4(.8f, .14f, .06f, 1);
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

        if (paused) {
            if (Input.GetKeyDown("up") || Input.GetKeyDown("down")) {
                if (selected == restart_option) {
                    selected = exit_option;
                } else {
                    selected = restart_option;
                }
                restart_option.color = white;
                exit_option.color = white;
                selected.color = red;
            }

            if (Input.GetKeyDown("return")) {
                if (selected == restart_option) {
                    Time.timeScale = time_scale;
                    Scene loadedLevel = SceneManager.GetActiveScene();
                    SceneManager.LoadScene(loadedLevel.buildIndex);
                } else {
                    Time.timeScale = time_scale;
                    SceneManager.LoadScene("SplashScreen");
                }
            }
        }
	}
}
