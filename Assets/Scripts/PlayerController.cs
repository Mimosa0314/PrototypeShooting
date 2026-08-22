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

        Vector3 buttonLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));

        Debug.Log(playerCollider.bounds.max);
        Debug.Log(topRight);

        if (playerCollider.bounds.max.y == topRight.y)
        {   
            /*
             * 画面上端では上入力できないようにする
             */
            Vector3 move = new Vector3(x, 0, 0);
            transform.position += move * moveSpeed * Time.deltaTime;

            Debug.Log("上端");

        }else if(playerCollider.bounds.min.y == buttonLeft.y && y < 0)
        {
            /*
             * 画面下端では下入力できないようにする
             */
            Vector3 move = new Vector3(x, 0, 0);
            transform.position += move * moveSpeed * Time.deltaTime;
            Debug.Log("下端");
        }
        else if(playerCollider.bounds.min.x == buttonLeft.x && x < 0)
        {
            /*
             * 画面左端では左入力できないようにする
             */
            Vector3 move = new Vector3(0, y, 0);
            transform.position += move * moveSpeed * Time.deltaTime;
            Debug.Log("左端");
        }
        else if (playerCollider.bounds.max.x == topRight.x && x > 0)
        {
            /*
             * 画面右端では右入力できないようにする
             */
            Vector3 move = new Vector3(0, y, 0);
            transform.position += move * moveSpeed * Time.deltaTime;
            Debug.Log("右端");

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
