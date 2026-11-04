using UnityEngine;

public class AppleEnemy : MonoBehaviour
{
    public float moveSpeed = 4f;
    
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }

}
