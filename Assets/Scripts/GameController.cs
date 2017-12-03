using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject battery_drain_overlay;
    public GameObject item_destroy_overlay;
    public GameObject win_level_overlay;
    public string next_level_name;

    private float time_scale;
    private bool waiting_for_restart;
    private bool waiting_for_next_level;

    void Start()
    {
        time_scale = Time.timeScale;
        waiting_for_restart = false;
        waiting_for_next_level = false;
    }

    void Update()
    {
        if (waiting_for_restart) {
            if (Input.GetKeyDown("return")) {
                Time.timeScale = time_scale;
                Scene loadedLevel = SceneManager.GetActiveScene();
                SceneManager.LoadScene(loadedLevel.buildIndex);
            }
        }

        if (waiting_for_next_level) {
            if (Input.GetKeyDown("return"))
            {
                Time.timeScale = time_scale;
                SceneManager.LoadScene(next_level_name);
            }
        }
    }

    public void lose_to_battery_drain() 
    {
        Time.timeScale = 0f;
        waiting_for_restart = true;
        battery_drain_overlay.SetActive(true);
    }

    public void lose_to_item_destroy()
    {
        Time.timeScale = 0f;
        waiting_for_restart = true;
        item_destroy_overlay.SetActive(true);
    }

    public void win_level()
    {
        Time.timeScale = 0f;
        waiting_for_next_level = true;
        win_level_overlay.SetActive(true);
    }
}
