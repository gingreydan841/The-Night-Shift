using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector2 movement;
    public float jumpForce = 5f;
    private bool isGrounded = true;
    private Rigidbody2D rb;
    private Animator anim;
    public GameObject lowAttackHitbox;
    public GameObject highAttackHitbox;

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if(isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
            anim.SetBool("IsJumping", true);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponentInChildren<Animator>(); //to get bear, not player
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2) transform.position + movement * Time.deltaTime * moveSpeed;
        anim.SetBool("IsWalking", movement != Vector2.zero);
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
            anim.SetBool("IsJumping", false);
        }
    }

    // input action = button (j & K), unity calls these when buttons are triggered
    public void OnHighAttack()
    {
        anim.SetTrigger("HighAttack");
        highAttackHitbox.SetActive(true);

        highAttackHitbox.GetComponent<HighAttackHitBox>()
            .Invoke("DisableHighAttackHitbox", 0.3f);
    }

    public void OnLowAttack()
    {
        anim.SetTrigger("LowAttack");
        lowAttackHitbox.SetActive(true);

        lowAttackHitbox.GetComponent<LowAttackHitBox>()
            .Invoke("DisableLowAttackHitbox", 0.3f);
    }

}
