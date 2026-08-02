using UnityEngine;

public class PlayerMachine : MonoBehaviour
{
    private int life = 1;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        /*
         *“G’e‚Æ‚ÌÚG”»’è 
         */
        if (collision.gameObject.tag == "enemyBullet")
        {
            Death();
        }
    }

    /*
     * €–S
     */
    void Death()
    {
        //‘Ì—Í‚ğ0‚É‚·‚é
        life = 0;
        Debug.Log("“G’e‚ÆÚGA€–S‚µ‚Ü‚µ‚½");
    }
}