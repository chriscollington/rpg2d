using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(6);
    }
}

