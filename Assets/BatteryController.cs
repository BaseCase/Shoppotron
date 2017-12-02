using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryController : MonoBehaviour 
{
    public float seconds_to_live;

    private Vector3 start_scale;
    private float start_time;


	void Start () 
    {
        start_time = Time.time;
        start_scale = transform.localScale;
	}
	
	void Update () 
    {
        float elapsed = Time.time - start_time;
        float time_left = Mathf.Clamp(seconds_to_live - elapsed, 0f, seconds_to_live);
        float percent_left = time_left / seconds_to_live;
        Vector3 new_scale = new Vector3(percent_left, 1f, 1f);
        transform.localScale = new_scale;
        transform.localPosition = new Vector3(-(1f - percent_left) / 2f, 0f, 0f);
	}
}
