using   UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    [SerializeField] private GameObject bullet;
    private float bulletSpeed = 5f;

    public PlayerBullet()
    {

    }
    void Start()
    {
        
    }

    void Update()
    {
        /*’e‚Ì‹““®
         * í‚Éˆê’è•ûŒü‚Éˆ—‚·‚é
         */
        transform.position += Vector3.up * bulletSpeed * Time.deltaTime;

    }
}
