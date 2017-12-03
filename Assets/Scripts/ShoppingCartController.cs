using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingCartController : MonoBehaviour 
{
    public int item_goal;

    private int items_captured;

	void Start () 
    {
        items_captured = 0;
	}

    void Update () 
    {
		
	}

    public void add_item(GameObject item)
    {
        items_captured++;
        // TODO: only works for one item
        item.transform.position = transform.position;
    }

    public bool is_full()
    {
        // TODO: make this generic instead of hard-coded;
        Debug.Log(items_captured);
        return items_captured >= item_goal;
    }
}
