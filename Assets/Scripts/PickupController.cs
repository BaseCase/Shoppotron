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
        cart.add_item(gameObject);

        // TODO: a little animation or something before destroying
        // TODO: Destroy is probably not the right thing; we want to keep it around so
        //       that the shopping cart can use it.
        Destroy(gameObject);
    }
}
