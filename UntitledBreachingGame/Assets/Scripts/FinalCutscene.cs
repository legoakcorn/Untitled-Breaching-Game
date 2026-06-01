using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class FinalCutscene : MonoBehaviour
{
    [SerializeField] private GameObject MainCam;
    [SerializeField] private GameObject PewieCam;
    [SerializeField] private GameObject Heli;
    [SerializeField] private GameObject Pewie;
    [SerializeField] private GameObject Rocket;
    [SerializeField] private GameObject PewieText;
    [SerializeField] private GameObject EndText;
    [SerializeField] private Transform RocketTarget;
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private float Pspeed = 0.5f;
    [SerializeField] private float Rspeed = 0.5f;
    private bool isFlyingUp;
    private bool PewieMove;
    private bool isFlyingForward;
    private bool RocketFly;

    private void Start()
    {
        FlyAway();
    }

    public void FlyAway()
    {
        Spinner.rotationSpeed = 2000f;
        Spinner2.rotationSpeed = 5000f;
        isFlyingUp = true;
        Rocket.SetActive(false);
        Invoke(nameof(PewieForward), 1f);
        Invoke(nameof(StopFlyUp), 3f);
        Invoke(nameof(HeliFlyForward), 6f);
        Invoke(nameof(BOOM), 8f);
        Invoke(nameof(EndScene), 11.5f);
        Invoke(nameof(EndGame), 14f);
    }

    private void Update()
    {
        if (RocketTarget == null)
        {
            Debug.LogWarning("Target not assigned in " + gameObject.name);
            return;
        }

        Vector3 currentPosition = Rocket.transform.position;
        Vector3 targetPosition = RocketTarget.position;

        if (isFlyingUp)
        {
            Heli.transform.Translate(new Vector3(0f, speed / 4 * Time.deltaTime, 0f));
        }

        if (PewieMove)
        {
            Pewie.transform.Translate(Pewie.transform.forward * Time.deltaTime * Pspeed * -1);
        }

        if (isFlyingForward)
        {
            Heli.transform.Translate(Heli.transform.right * Time.deltaTime * speed);
            Heli.transform.Translate(Heli.transform.up * Time.deltaTime * speed / 2);
        }

        if (RocketFly)
        {
            Rocket.SetActive(true);
            Rocket.transform.LookAt(RocketTarget);
            Rocket.transform.position = Vector3.MoveTowards(currentPosition, targetPosition, Rspeed * Time.deltaTime);
            
        }

        if (Vector3.Distance(Rocket.transform.position, RocketTarget.transform.position) < 1f)
        {
            Destroy(Rocket);
            Destroy(Heli);
        }
    }

    private void StopFlyUp()
    {
        isFlyingUp = false;
        PewieMove = false;
        MainCam.SetActive(false);
        PewieCam.SetActive(true);
        PewieText.SetActive(true);
    }

    private void PewieForward()
    {
        PewieMove = true;
    }

    private void HeliFlyForward()
    {
        MainCam.SetActive(true);
        PewieCam.SetActive(false);
        PewieText.SetActive(false);
        isFlyingForward = true;
    }

    private void BOOM()
    {
        RocketFly = true;
    }

    private void EndScene()
    {
        EndText.SetActive(true);
    }

    private void EndGame()
    {
        SceneManager.LoadScene(0);
    }
}
