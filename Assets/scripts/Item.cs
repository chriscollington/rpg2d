using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private string itemName;

    [SerializeField]
    private int quantity;

    [SerializeField]
    private Sprite sprite;

    public InventoryManager InventoryManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // InventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag== "Player")
        {
            InventoryManager.AddItem(itemName, quantity, sprite);
            Destroy(gameObject);
        }
    }
}
