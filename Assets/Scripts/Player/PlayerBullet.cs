using   UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    [SerializeField] private GameObject bullet;
    [SerializeField] private EnemyStatus enemyStatus;

    private float bulletSpeed = 5f;

    public PlayerBullet()
    {

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
        transform.position += Vector3.up * bulletSpeed * Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
         * 弾が敵機に衝突したら呼び出し
         */
        if(collision.gameObject.tag == "enemy")
        {
            enemyStatus.TakeDamage();
        }
    }


    /*
     * 画面外に出たらオブジェクトを破棄
     * 条件をつけず出た時点で即破棄（試作）
     */
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
