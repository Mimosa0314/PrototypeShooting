using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private bool isMoving = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update
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
}
