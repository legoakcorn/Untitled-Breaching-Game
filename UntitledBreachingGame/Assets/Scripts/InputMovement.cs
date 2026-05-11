using UnityEngine;

public class InputMovement : MonoBehaviour
{
    //Instance Variables
    private PlayerInput playerInput;
    public PlayerInput.PlayerActions player;

    public static bool Freeze;
    private PlayerMovement motor;
    private PlayerLook look;
    private void Awake()
    {
        playerInput = new PlayerInput();
        player = playerInput.Player;

        motor = GetComponent<PlayerMovement>();
        look = GetComponent<PlayerLook>();

        player.Jump.performed += ctx => motor.Jump();
    }
    private void Update()
    {
        if (Freeze)
        {
            return;
        }
        
            motor.ProcessMove(player.Movement.ReadValue<Vector2>());
    }
    private void LateUpdate()
    {
        if (Freeze)
        {
            return;
        }
        look.ProcessLook(player.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        player.Enable();
    }

    private void OnDisable()
    {
        player.Disable();
    }
}
