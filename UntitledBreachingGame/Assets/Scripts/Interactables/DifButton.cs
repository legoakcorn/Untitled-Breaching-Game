using UnityEngine;
using UnityEngine.SceneManagement;

public class DifButton : NewInteractables
{
    protected override void Interact()
    {
        SceneManager.LoadScene(6);
        GetComponent<FinalCutscene>().FlyAway();
    }
}
