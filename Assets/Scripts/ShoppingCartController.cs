using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingCartController : MonoBehaviour 
{
	void Start () 
    {
		
	}

    void Update () 
    {
		
	}

    public void add_item(GameObject item)
    {
        Debug.Log("OK we are adding it" + item.ToString());
    }
}
