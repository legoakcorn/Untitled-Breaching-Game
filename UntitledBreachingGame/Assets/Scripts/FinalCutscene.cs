using UnityEngine;

public class FinalCutscene : MonoBehaviour
{
    [SerializeField] private GameObject MainCam;
    [SerializeField] private GameObject PewieCam;
    [SerializeField] private GameObject Heli;
    [SerializeField] private GameObject Pewie;
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private float Pspeed = 0.5f;
    private bool isFlyingUp;
    private bool PewieMove;
    private bool isFlyingForward;

    public void FlyAway()
    {
        Spinner.rotationSpeed = 2000f;
        Spinner2.rotationSpeed = 5000f;
        isFlyingUp = true;
        Invoke(nameof(PewieForward), 1f);
        Invoke(nameof(StopFlyUp), 3f);
    }

    private void Update()
    {
        if (isFlyingUp)
        {
            Heli.transform.Translate(new Vector3(0f, speed / 4 * Time.deltaTime, 0f));
        }

        else if (PewieMove)
        {
            Pewie.transform.Translate(Pewie.transform.forward * Time.deltaTime * Pspeed);
        }

        else if (isFlyingForward)
        {
            Heli.transform.Translate(Heli.transform.forward * Time.deltaTime * speed);
            Heli.transform.Translate(Heli.transform.up * Time.deltaTime * speed / 2);
        }
    }

    private void StopFlyUp()
    {
        isFlyingUp = false;
        PewieMove = false;
        MainCam.SetActive(false);
        PewieCam.SetActive(true);
    }

    private void PewieForward()
    {
        PewieMove = true;
    }

    private void HeliFlyForward()
    {
        MainCam.SetActive(true);
        PewieCam.SetActive(false);
    }
}
