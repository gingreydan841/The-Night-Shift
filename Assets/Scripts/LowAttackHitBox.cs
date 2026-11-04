using UnityEngine;

public class LowAttackHitBox : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LowEnemy"))
        {
            Destroy(collision.gameObject);
        }
    }

    public void DisableLowAttackHitbox()
    {
        gameObject.SetActive(false);
    }
}
