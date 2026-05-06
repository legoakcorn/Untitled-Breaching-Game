using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class InteractableTwo : MonoBehaviour
{
    //message to player when lookign at interaction
    public string promptMessage;

    //this function will be called from our player
    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        //no code in here
        //template function
    }
}
