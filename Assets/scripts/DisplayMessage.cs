using UnityEngine;
using UnityEngine.UI;

public class DisplayMessage : MonoBehaviour
{
    public GameObject messageText;
    // Drag your Text hodler element here in the Inspector

    [SerializeField] private Text childText;

    // Function to set the message text
    public void ShowMessage(string message)
    {

        if (message != null) {
            childText.text = message;
        }

        //Show message
        messageText.SetActive(true);
    }

    public void ShowDoor()
    {

        //Show message
        messageText.SetActive(true);
    }

    // Function to hide the message text
    public void HideMessage()
    {
        messageText.SetActive(false);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the object entering the trigger is the player
        if (other.gameObject.tag == "Player")
        {
            // display win message
            ShowDoor();
           
        }
    }

}


