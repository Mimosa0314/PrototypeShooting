using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    [SerializeField] private GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        //“G‹@‚Æ’¼ÚÚG‚µ‚½ê‡‚Éƒ_ƒ[ƒW‚ğ—^‚¦‚é
        if(collision.gameObject.tag == "Player")
        {
            PlayerStatus playerStatus = player.GetComponent<PlayerStatus>();

            Debug.Log(playerStatus);
            playerStatus.TakeDamage();
        }
    }
}
