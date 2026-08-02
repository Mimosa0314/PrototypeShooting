using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }


    void Update()
    {
        /*
         * AWSDˆÚ“®
         */
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, y, 0);

        transform.position += move * moveSpeed * Time.deltaTime;
    }
}
