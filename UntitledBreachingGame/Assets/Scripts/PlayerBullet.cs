using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            print("hit " + collision.gameObject.name + " !");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
