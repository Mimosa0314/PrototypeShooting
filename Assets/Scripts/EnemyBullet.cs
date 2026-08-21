using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Transform player;
    private bool isMoving = false;
    private Vector3 direction;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
        
    // Update is called once per framea
    private void Update()
    {
        if (!isMoving && Input.GetKeyDown(KeyCode.Space))
        {
            Direction();
            isMoving = true;
        }

        if (isMoving)
        {
            transform.position += 
                direction * moveSpeed * Time.deltaTime;
        }
    
}
    private void Direction()
    {
        direction =
        (player.position - transform.position).normalized;
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }



}
