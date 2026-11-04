using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Floor1"); //play button uses this to load scene
    }
    
}
