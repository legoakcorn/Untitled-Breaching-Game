using UnityEngine;

public class NPC1Interact : NewInteractables
{
    [SerializeField] private GameObject NPCText;
    protected override void Interact()
    {
        NPCText.SetActive(true);
        InputMovement.Freeze = true;
        
        NPCText.SetActive(false);
        InputMovement.Freeze = false;
    }
}

