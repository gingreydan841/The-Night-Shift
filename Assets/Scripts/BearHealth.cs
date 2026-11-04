using UnityEngine;
using UnityEngine.SceneManagement;

public class BearHealth : MonoBehaviour
{
    public int hearts = 3;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public void TakeDamage()
    {
        hearts--;
        
        if (hearts == 2)
        {
            heart3.SetActive(false);
        }
        else if (hearts == 1)
        {
            heart2.SetActive(false);
        }
        else if (hearts <= 0)
        {
            heart1.SetActive(false);
            SceneManager.LoadSceneAsync("GameOver");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LowEnemy") ||
            collision.gameObject.CompareTag("HighEnemy"))
        {
            TakeDamage();
            Destroy(collision.gameObject);
        }
    }
}
