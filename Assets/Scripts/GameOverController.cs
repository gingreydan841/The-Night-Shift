using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
