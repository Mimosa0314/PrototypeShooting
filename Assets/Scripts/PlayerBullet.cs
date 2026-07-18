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
        Vector2 bulletPos = transform.position;

    }

    //’e‚Ì”­Ë
    public void Firing(Vector2 pos)
    {
        Instantiate(bullet, pos, Quaternion.identity);
    }
}
