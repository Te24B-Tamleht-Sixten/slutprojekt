using JetBrains.Annotations;
using UnityEngine;


public class enemyCuntroelr : MonoBehaviour
{
    private enemySpawnerCContorler spawner;
    

   [Header("Movement")]
    public float speed = 2f;
    public bool moveRight = true;

    [Header("Jumping")]
    public float jumpForce = 5f;
    public float minJumpDelay = 1f;
    public float maxJumpDelay = 3f;

    private Rigidbody2D rb;
    private float nextJumpTime;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ScheduleNextJump();
    }

    private void Update()
    {
        // Horizontal movement
        float direction = moveRight ? 1f : -1f;
        rb.linearVelocity = new Vector2(direction * speed, rb.linearVelocity.y);
        // Random jumping
        if (Time.time >= nextJumpTime)
        {
            Jump();
            ScheduleNextJump();
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void ScheduleNextJump()
    {
        nextJumpTime = Time.time + Random.Range(minJumpDelay, maxJumpDelay);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    if (collision.tag=="Bullet")
    {
        
        Destroy(gameObject);
        spawner = FindObjectOfType<enemySpawnerCContorler>();
        spawner.enemyKillCount++;
        Debug.Log(spawner.enemyKillCount);
    }
    }
}
