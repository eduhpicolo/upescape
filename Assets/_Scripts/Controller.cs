using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private Player player;
    private GameObject CanvasInteract;
    
    public static Item item;
    private Item _item;
    private Item Item
    {
        get
        {
            return _item;
        }
        set
        {
            if (value != item)
                _item = value;
        }
    }

    public static string itemSelected;
    private string selectedItem;
    private string ItemSelected
    {
        get
        {
                return selectedItem;
        }
        set
        {
            if (value != itemSelected)
                selectedItem = value;
        }
    }
    
    void Awake()
    {
        player = FindObjectOfType<Player>();
        CanvasInteract = FindObjectOfType<IteractedCanvas>(true).gameObject;
    }

    void Update()
    {
        if (itemSelected != "" && itemSelected != selectedItem)
            ItemSelected = itemSelected;
        
        if (item != _item)
            Item = item;
        
        if (player.onMove)
        {
            if (player.tagCollider == itemSelected)
            {
                if (item.isInteract)
                    CanvasInteract.SetActive(true);
                else
                    StoreItem(item);
            }             
        }
    }

    private void StoreItem(Item item)
    {
        if(item != null)
            item.transform.localPosition = new Vector3(-8,-4,0);
    }
}
