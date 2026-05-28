using UnityEngine;


public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private float interactDistance = 3f;
    private Camera cam;

    private void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    private void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);//create forward ray from center of camera
        RaycastHit hitInfo;
        Debug.DrawRay(ray.origin, ray.direction * interactDistance);

        if (Physics.Raycast(ray, out hitInfo, interactDistance))
        {
            if (hitInfo.transform.CompareTag("InteractableItem") && Input.GetKeyDown(KeyCode.R)) 
            {
                // Check if the component exists before calling to avoid NullReferenceErrors
                if (hitInfo.transform.TryGetComponent(out NewInteractables interactable))
                {
                    interactable.BaseInteract();
                }
            }

        }
    }
}
