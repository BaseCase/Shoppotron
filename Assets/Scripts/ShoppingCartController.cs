using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingCartController : MonoBehaviour 
{
    public int item_goal;
    public GameObject item_container;

    private int items_captured;
    private Vector3 first_item_position;

	void Start () 
    {
        items_captured = 0;
        first_item_position = item_container.transform.position;
	}

    void Update () 
    {
		
	}

    public void add_item(GameObject item)
    {
        items_captured++;
        // TODO: only works for one item
        item.transform.position = first_item_position;
    }

    public bool is_full()
    {
        return items_captured >= item_goal;
    }
}
