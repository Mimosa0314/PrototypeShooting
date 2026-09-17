using   UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    [SerializeField] private GameObject bullet;

    [SerializeField] private GameObject enemy;
    private EnemyStatus enemyStatus;

    private float bulletSpeed = 5f;

    private Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        

    }

    void Start()
    {
        
    }

    void Update()
    {
        /*
         * 弾の挙動
         * 常に一定方向に処理する
         */
        rb.MovePosition(
            rb.position +
            Vector2.up * bulletSpeed * Time.deltaTime
        );
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        /*
         * 弾が敵機に衝突したら呼び出し
         */
        if (collision.gameObject.tag == "enemy")
        {
            enemyStatus = enemy.GetComponent<EnemyStatus>();
            enemyStatus.TakeDamage();

            //弾を消滅させる
            DestroyBullet();
        }

    }


    /*
     * 画面外に出たらオブジェクトを破棄
     * 条件をつけず出た時点で即破棄（試作）
     */
    private void OnBecameInvisible()
    {
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
