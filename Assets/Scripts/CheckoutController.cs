using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckoutController : MonoBehaviour 
{
    public GameObject shopping_cart;

	void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        ShoppingCartController sc = shopping_cart.GetComponent<ShoppingCartController>();

        // TODO: only if colliding with player
        if (sc.is_full()) {
            // congrats
            Debug.Log("you win");
        } else {
            // ruh roh
            Debug.Log("get rekt");
        }
    }
}
