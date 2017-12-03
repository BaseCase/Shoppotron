using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject battery_drain_overlay;
    public GameObject item_destroy_overlay;

    private float time_scale;
    private bool waiting_for_continue;

    void Start()
    {
        time_scale = Time.timeScale;
        waiting_for_continue = false;
    }

    void Update()
    {
        if (waiting_for_continue) {
            if (Input.GetKeyDown("return")) {
                Debug.Log("restarting");
                Time.timeScale = time_scale;
                Scene loadedLevel = SceneManager.GetActiveScene();
                SceneManager.LoadScene(loadedLevel.buildIndex);
            }
        }
    }

    public void lose_to_battery_drain() 
    {
        Time.timeScale = 0f;
        waiting_for_continue = true;
        battery_drain_overlay.SetActive(true);
    }

    public void lose_to_item_destroy()
    {
        Time.timeScale = 0f;
        waiting_for_continue = true;
        item_destroy_overlay.SetActive(true);
    }
}
