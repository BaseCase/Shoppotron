using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppotronController : MonoBehaviour 
{
    public float rotation_speed;
    public float movement_speed;

    private Animator anim;
    private AudioSource audio;
    private bool audio_is_playing;

	void Start () 
    {
        anim = gameObject.GetComponent<Animator>();
        anim.speed = 0;
        audio = gameObject.GetComponent<AudioSource>();
        audio_is_playing = false;
    }
	
	void FixedUpdate () 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 rotation = new Vector3(0, 0, -h) * rotation_speed;
        Vector3 movement = new Vector3(0, v, 0) * movement_speed;
        transform.Rotate(rotation);
        transform.Translate(movement);
        anim.speed = Mathf.Abs(v);

        { // audio
            if (Mathf.Abs(v) > 0) {
                if (audio_is_playing) {
                    // don't start what's already playing
                } else {
                    audio.Play();
                    audio_is_playing = true;
                }
            } else {
                if (audio_is_playing) {
                    audio.Stop();
                    audio_is_playing = false;
                } else {
                    // don't stop it again
                }
            }
        }
	}
}
