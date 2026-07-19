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

    /*“G’e‚Æ‚ÌÚG”»’è
     * 
     */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //‘Ì—Í‚ğ0‚É‚·‚é
        life = 0;
        Debug.Log("“G’e‚ÆÚGA€–S‚µ‚Ü‚µ‚½");
    }

}