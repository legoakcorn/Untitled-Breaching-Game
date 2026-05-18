using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCanvasScript : MonoBehaviour 
{
    [SerializeField] public GameObject Mission1Folder;
    [SerializeField] public GameObject Mission2Folder;
    [SerializeField] public GameObject Mission3Folder;
    [SerializeField] public GameObject SecertMissionFolder;
    public void Back1()
    {
        InputMovement.Freeze = false;
        Cursor.lockState = CursorLockMode.Locked;
        Mission1Folder.SetActive(false);
    }
    public void Back2()
    {
        InputMovement.Freeze = false;
        Cursor.lockState = CursorLockMode.Locked;
        Mission2Folder.SetActive(false);
    }
    public void Back3()
    {
        InputMovement.Freeze = false;
        Cursor.lockState = CursorLockMode.Locked;
        Mission3Folder.SetActive(false);
    }
    public void BackSecret()
    {
        InputMovement.Freeze = false;
        Cursor.lockState = CursorLockMode.Locked;
        SecertMissionFolder.SetActive(false);
    }
    public void PlayMission1 ()
    {
        GetComponent<CutsceneStartScript>().FlyAway();
        Invoke(nameof(LoadScene1), 5f);
    }
    public void PlayMission2()
    {
        GetComponent<CutsceneStartScript>().FlyAway();
        Invoke(nameof(LoadScene2), 5f);
    }
    public void PlayMission3()
    {
        GetComponent<CutsceneStartScript>().FlyAway();
        Invoke(nameof(LoadScene3), 5f);
    }
    public void PlaySecretMission()
    {
        GetComponent<CutsceneStartScript>().FlyAway();
        Invoke(nameof(LoadSceneSec), 5f);
    }

    private void LoadScene1()
    {
        SceneManager.LoadScene(1);
    }
    private void LoadScene2()
    {
        SceneManager.LoadScene(2);
    }
    private void LoadScene3()
    {
        SceneManager.LoadScene(3);
    }
    private void LoadSceneSec()
    {
        SceneManager.LoadScene(4);
    }
}
