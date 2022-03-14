using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSesame : MonoBehaviour
{
    private Animator doorAnim;

    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayOpenDoorAnim()
    {
        doorAnim.Play("Opening");
    }
}
