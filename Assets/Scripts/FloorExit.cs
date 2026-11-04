using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorExit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync("Floor2");
        }
    }
}
