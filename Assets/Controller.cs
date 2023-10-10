using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private GameObject CanvasInteract;

    static public string itemSelected;
    static public Item item;
    [SerializeField] private string ItemSelected;
    [SerializeField] private Item Item;
    

    void Update()
    {
        ItemSelected = itemSelected;
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
        item.transform.localPosition = new Vector3(-8,-4,0);
    }
}
