using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float speed = 3.0f;

    void Update()
    {
        if (player != null)
        {
            // Move toward player position at a constant speed
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("GAMEOVER!");

        }
    }
}
