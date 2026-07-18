using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private PlayerBullet playerBullet;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Fキー（仮）を押すと弾クラスを呼び出す
        if (Input.GetKeyDown(KeyCode.F))
        {
            Vector2 playerPos = transform.position;
            playerBullet.Firing(playerPos);   
        }
    }
}
