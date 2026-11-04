using UnityEngine;

public class HighAttackHitBox : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("HighEnemy"))
        {
            Destroy(collision.gameObject);
        }
    }

    public void DisableHighAttackHitbox()
    {
        gameObject.SetActive(false);
    }
}
