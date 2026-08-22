using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    void Start()
    {
        
    }

 
    void Update()
    {
        /*
         * Fキー（仮）を押すと弾クラスを呼び出す
         */
        if (Input.GetKeyDown(KeyCode.F))
        {
            Vector2 playerPos = transform.position;
            playerPos.y += 0.50f;
            Instantiate(bullet, playerPos, Quaternion.identity);
        }
    }
}
