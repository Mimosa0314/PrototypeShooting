using UnityEngine;

public class PlayerMachine : MonoBehaviour
{
    //敵の体力とかあるやつ
    //[SerializeField] private Enemy enemy; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //攻撃ボタン
        if (Input.GetKeyDown(KeyCode.Space)){
            //敵の判定受付メソッド呼び出し
            /*
             * enemy.TakeDamage();
             * 
             */
        }

        
        
    }
}
