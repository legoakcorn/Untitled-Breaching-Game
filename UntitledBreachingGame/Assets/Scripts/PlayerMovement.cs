using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f; //W speed son <3 <3
    [SerializeField] private float jumpForce = 4f;
    [SerializeField] private float gravity = -9.8f;
    [SerializeField] public static float playerHealth = 3f;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = (input.x * transform.right + input.y * transform.forward).normalized;
        controller.Move(moveDirection * Time.deltaTime * speed); //Please speed I need this

        playerVelocity.y += gravity * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        if (controller.isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }
    }

    public void Jump()
    {
        if (controller.isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpForce * gravity * -1f);
        }
    }

    void Update()
    {
        // Check if Left Shift is held down
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 2;
        }
        if (playerHealth < 1) 
        {
            SceneManager.LoadScene(0);
        
        }

    }
}
