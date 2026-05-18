using NUnit.Framework;
using UnityEngine;
using UnityEngine.Rendering;

public class Spinner : MonoBehaviour
{
    [SerializeField] public static float rotationSpeed = 100f;
    void Update()
    {
        // Rotates the object around the Y-axis (up)
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
