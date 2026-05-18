using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    // Drag the object you want to look at into this slot in the Inspector
    public Transform target;

    void Update()
    {
        if (target != null)
        {
            // Rotates the camera to face the target every frame
            transform.LookAt(target);
        }
    }
}
