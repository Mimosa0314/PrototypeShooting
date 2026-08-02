using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private bool isMoving = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isMoving = true;
        }

        if (isMoving)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(
            "EnemyBullet‚ªÚG‚µ‚Ü‚µ‚½BÚG‘ŠèF" +
            other.gameObject.name
        );

        PlayerMachine playerMachine =
            other.GetComponentInParent<PlayerMachine>();

        if (playerMachine == null)
        {
            return;
        }

        playerMachine.TakeDamage();
    }
}
