using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneswitch : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(4);
    }
}
