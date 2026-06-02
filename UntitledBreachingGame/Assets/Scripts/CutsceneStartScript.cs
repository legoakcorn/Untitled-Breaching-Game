using UnityEngine;

public class CutsceneStartScript : MonoBehaviour
{
    [SerializeField] private Camera cam1;
    [SerializeField] private Camera cam2;
    [SerializeField] private GameObject Heli;
    [SerializeField] private float speed = 0.5f;
    private bool isFlying;

    public void FlyAway()
    {
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(true);
        InputMovement.Freeze = true;
        Spinner.rotationSpeed = 2000f;
        Spinner2.rotationSpeed = 5000f;
        GetComponent<MenuCanvasScript>().Mission1Folder.SetActive(false);
        GetComponent<MenuCanvasScript>().Mission2Folder.SetActive(false);
        GetComponent<MenuCanvasScript>().Mission3Folder.SetActive(false);
        GetComponent<MenuCanvasScript>().SecertMissionFolder.SetActive(false);
        isFlying = true;
        Invoke(nameof(Unstuck), 5f);

    }

    private void Update()
    {
        if (isFlying)
        {
            Heli.transform.Translate(new Vector3(0f, speed / 2 * Time.deltaTime, speed * Time.deltaTime));
        }
    }

    private void Unstuck()
    {
        InputMovement.Freeze = false;
        Spinner.rotationSpeed = 100f;
        Spinner2.rotationSpeed = 100f;
    }
}
