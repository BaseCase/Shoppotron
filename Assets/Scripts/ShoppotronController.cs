using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppotronController : MonoBehaviour 
{
    public float rotation_speed;
    public float movement_speed;

    private Animator anim;

	void Start () 
    {
        anim = gameObject.GetComponent<Animator>();
        anim.speed = 0;
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
	}
}
