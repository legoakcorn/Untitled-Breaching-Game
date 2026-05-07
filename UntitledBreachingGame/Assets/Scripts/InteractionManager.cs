using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public float interactionDistance = 3f;
    public LayerMask interactableLayer = 6;
    public Transform playerCamera;

    private IInteractable _currentInteractable;


    // Update is called once per frame
    void Update()
    {
        CheckForInteractable();

        if (_currentInteractable != null && Input.GetKeyDown(KeyCode.E))
        {
            _currentInteractable.Interact();
        }
        if (_currentInteractable != null && Input.GetKeyDown(KeyCode.R))
        {
            _currentInteractable.Interact();
        }
    }

    private void CheckForInteractable()
    {
        Ray ray = new Ray(playerCamera.position, playerCamera.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, interactionDistance, interactableLayer))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();

            if (interactable != null) 
            {
                if (_currentInteractable != interactable)
                {
                    ResetOutline();
                    _currentInteractable = interactable;

                }
                return;
            }
        }
        ResetOutline();
    }  

    private void ResetOutline()
    {
        _currentInteractable = null;
    }
}
