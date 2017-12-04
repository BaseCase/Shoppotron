﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour 
{
    public GameObject shopping_cart;
    public GameObject game_controller;

    private ShoppingCartController cart;
    private AudioSource pickup_get_audio;

	void Start () 
    {
        cart = shopping_cart.GetComponent<ShoppingCartController>();
        pickup_get_audio = gameObject.GetComponent<AudioSource>();
	}
	
    void Update () 
    {
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            cart.add_item(gameObject);
            pickup_get_audio.Play();
        } else if (collision.CompareTag("Shelf")) {
            Destroy(gameObject);
            GameController gc = game_controller.GetComponent<GameController>();
            gc.lose_to_item_destroy();
        } else {
            // ignore anything that's not player or a shelf
        }
    }
}
