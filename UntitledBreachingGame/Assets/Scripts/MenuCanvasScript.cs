using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCanvasScript : MonoBehaviour 
{
    [SerializeField] private GameObject Mission1Folder;
    [SerializeField] private GameObject Mission2Folder;
    [SerializeField] private GameObject Mission3Folder;
    [SerializeField] private GameObject SecertMissionFolder;
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
        SceneManager.LoadScene(1);
    }
    public void PlayMission2()
    {
        SceneManager.LoadScene(2);
    }
    public void PlayMission3()
    {
        SceneManager.LoadScene(3);
    }
    public void PlaySecretMission()
    {
        SceneManager.LoadScene(4);
    }

}
