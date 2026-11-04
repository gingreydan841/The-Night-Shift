using UnityEngine;
using UnityEngine.SceneManagement;

public class CongratsExit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync("Congrats");
        }
    }
}
