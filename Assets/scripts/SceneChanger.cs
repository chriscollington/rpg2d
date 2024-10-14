using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger  : MonoBehaviour
{
   
   public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Exit()
    {
        Application.Quit();
    }

    void Start() {
        Scene currentScene = SceneManager.GetActiveScene(); 
        Debug.Log("Current Scene Name: " + currentScene.name);
    }
    

}
