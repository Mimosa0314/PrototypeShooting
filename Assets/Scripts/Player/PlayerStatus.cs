using UnityEngine;

public class PlayerStatus: MonoBehaviour
{
    private int life = 1;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("PlayerStatus‘¤‚ÅÚG‚ğŒŸ’m‚µ‚Ü‚µ‚½");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        /*a
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