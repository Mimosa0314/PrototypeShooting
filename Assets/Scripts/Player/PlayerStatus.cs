using UnityEngine;

<<<<<<<< HEAD:Assets/Scripts/Player/PlayerStatus.cs
public class PlayerStatus: MonoBehaviour
========
public class PlayerStatus : MonoBehaviour
>>>>>>>> 41393cb1c7e1d4994c937c779f3edb4114ad571a:Assets/Scripts/PlayerManager/PlayerStatus.cs
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
            TakeDamage();
        }
    }

    
    /*
     * €–S
     */
    public void TakeDamage()
    {
        //‘Ì—Í‚ğ0‚É‚·‚é
        life = 0;
        Debug.Log("“G’e‚ÆÚGA€–S‚µ‚Ü‚µ‚½");
    }
    
}