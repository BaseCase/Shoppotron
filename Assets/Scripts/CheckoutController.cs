using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckoutController : MonoBehaviour 
{
    public GameObject shopping_cart;
    public GameObject game_controller;

	void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        ShoppingCartController sc = shopping_cart.GetComponent<ShoppingCartController>();

        if (collision.CompareTag("Player")) {
            if (sc.is_full()) {
                GameController gc = game_controller.GetComponent<GameController>();
                gc.win_level();
            } else {
                Debug.Log("You don't have all the items!");
            }
        }
    }
}
