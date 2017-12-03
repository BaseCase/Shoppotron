using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour 
{
    public GameObject shopping_cart;

    private ShoppingCartController cart;

	void Start () 
    {
        cart = shopping_cart.GetComponent<ShoppingCartController>();
	}
	
    void Update () 
    {
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        // TODO: make work for destroy collision
        //GameObject other = collision.GetComponent<GameObject>();
        if (collision.CompareTag("Player")) {
            cart.add_item(gameObject);
        }
        // TODO: a little animation or something before moving
    }
}
