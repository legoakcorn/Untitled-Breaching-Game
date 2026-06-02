using UnityEngine;
using UnityEngine.UI;
public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("hit " + collision.gameObject.name + " !");

            PlayerMovement.playerHealth = PlayerMovement.playerHealth -1;

            
        }
    }
}



