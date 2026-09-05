using UnityEngine;

public class EnemyStatus : MonoBehaviour
{

    private int life = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        life --;

        if(life == 0)
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }


}
