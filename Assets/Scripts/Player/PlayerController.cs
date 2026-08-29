using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveSpeed = 5f;

    private BoxCollider2D playerCollider;

    private Camera camera;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;

        playerCollider = GetComponent<BoxCollider2D>();

        camera = Camera.main;
    }


    void Update()
    {
        /*
         * AWSD移動
         */
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));


        if (playerCollider.bounds.max.y >= topRight.y && y > 0)
        {

            if(playerCollider.bounds.min.x <= bottomLeft.x && x < 0)
            {
                /*
                 * 左上かつ左入力の場合移動させない
                 */

            }else if(playerCollider.bounds.min.x <= bottomLeft.x && x > 0)
            {
                /*
                 * 左上かつ右入力の場合
                 */
                Vector3 move = new Vector3(x, 0, 0);
                transform.position += move * moveSpeed * Time.deltaTime;

            }else if (playerCollider.bounds.min.x >= topRight.x && x > 0)
            {
                /*
                 * 右上かつ右入力の場合移動させない
                 */

            }
            else if (playerCollider.bounds.min.x >= topRight.x && x > 0)
            {
                /*
                 * 右上かつ左入力の場合
                 */
                Vector3 move = new Vector3(x, 0, 0);
                transform.position += move * moveSpeed * Time.deltaTime;

            } else
            {
                /*
                 * 画面上端では上入力できないようにする
                 */
                Vector3 move = new Vector3(x, 0, 0);
                transform.position += move * moveSpeed * Time.deltaTime;
            }


        }
        else if (playerCollider.bounds.min.y <= bottomLeft.y && y < 0 )
        {
            /*
             * 画面下端では下入力できないようにする
             */
            Vector3 move = new Vector3(x, 0, 0);
            transform.position += move * moveSpeed * Time.deltaTime;
        }
        else if (playerCollider.bounds.min.x <= bottomLeft.x && x < 0)
        {
            /*
             * 画面左端では左入力できないようにする
             */
            Vector3 move = new Vector3(0, y, 0);
            transform.position += move * moveSpeed * Time.deltaTime;
        }
        else if (playerCollider.bounds.max.x >= topRight.x && x > 0)
        {
            /*
             * 画面右端では右入力できないようにする
             */
            Vector3 move = new Vector3(0, y, 0);
            transform.position += move * moveSpeed * Time.deltaTime;

        }
        else
        {
            /*
             * いずれの端にも接していない場合
             */

            Vector3 move = new Vector3(x, y, 0);
            transform.position += move * moveSpeed * Time.deltaTime;
        }


    }
}
