using System;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isInteract;
    public bool isClicked;

    private void Start()
    {
        
    }

    private void OnMouseDown()
    {
        isClicked = true;
        Controller.itemSelected = gameObject.name;
        Controller.item = this.gameObject.GetComponent<Item>();
    }
}
