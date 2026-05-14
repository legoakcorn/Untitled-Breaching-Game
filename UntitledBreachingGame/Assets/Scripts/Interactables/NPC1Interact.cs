using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class NPC1Interact : NewInteractables
{
    [SerializeField] private GameObject NPCText;
    [SerializeField] private float NPCTextDuration;
    protected override void Interact()
    {
        NPCText.SetActive(true);
        InputMovement.Freeze = true;
        Invoke(nameof(ResetText), NPCTextDuration);
    }

    private void ResetText()
    {
        NPCText.SetActive(false);
        InputMovement.Freeze = false;
    }
}

