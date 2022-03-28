using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myDoorController : MonoBehaviour
{
    private Animator doorAnim;
    private bool doorOpen = false;

    void Awake()
    {
        doorAnim = gameObject.getComponent<Animator>();
    }

    void PlayAnimation()
    {
        if(!doorOpen)
        {
            doorAnim.Play("DoorOpen", 0, 0.0f);
            doorOpen = true;
        }
        else
        {
            doorAnim.Play("DoorClose", 0, 0.0f);
            doorOpen = false;
        }
    }
}
