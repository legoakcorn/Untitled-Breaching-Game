using UnityEngine;

public class MissionSelect1 : NewInteractables
{
    [SerializeField] private GameObject m_gameObject;
    protected override void Interact()
    {
        
        InputMovement.Freeze = true;
        Cursor.lockState = CursorLockMode.None;
        
        m_gameObject.SetActive(true);
    }
}
