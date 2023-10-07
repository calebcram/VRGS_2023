using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePassthroughButton : MonoBehaviour
{
    //Gameobject to hold the virtual environment.
    public GameObject ToggleObject;

    //Functionallity to toggle the virtual environment
    public void ToggleEnvironment()
    {
        if (ToggleObject.activeInHierarchy == true)
            ToggleObject.SetActive(false);
        else
            ToggleObject.SetActive(true);
    }
}
