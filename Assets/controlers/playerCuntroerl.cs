using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float lookPositionCountDown=0;

    public GameObject bulletPrefab;
    public float bulletSpeed = 100f;
    public Transform firePoint;

    public bool lookRight =true;
    public float moveSpeed = 7f;
    public float jumpForce = 30f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    public Sprite middleSprite;
    public Sprite rightSprite;
    public Sprite leftSprite;

    private Rigidbody2D rb; // copilot
    private SpriteRenderer sr; // copilot
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(move * moveSpeed, rb.linearVelocity.y);

        
        if(lookPositionCountDown<0)
        {
            sr.sprite = middleSprite;
        }
        else
        {
            lookPositionCountDown=lookPositionCountDown-(1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Shoot();
        }


        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.7f, groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
    void Shoot() // copilot
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // Shoot toward mouse position
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePos - firePoint.position).normalized;

        rb.linearVelocity = direction * bulletSpeed;

        if(mousePos.x>transform.position.x)
        {
            lookRight=true;
            sr.sprite = rightSprite;
            lookPositionCountDown=100;
        }
        else
        {
            lookRight=false;
            sr.sprite = leftSprite;
            lookPositionCountDown=100;
        }
    }
}
