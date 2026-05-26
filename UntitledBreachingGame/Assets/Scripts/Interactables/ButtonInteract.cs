using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInteract : NewInteractables
{
    protected override void Interact()
    {

        SceneManager.LoadScene(5);
    }
}
