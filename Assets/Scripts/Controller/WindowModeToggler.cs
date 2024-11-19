using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowModeToggler : MonoBehaviour
{

    Toggle windowToggleUI;

    private void Awake()
    {
        windowToggleUI = GetComponent<Toggle>();
    }

    public void ToggleWindowType()
    {
        if(windowToggleUI)
        {
            HandleWindowToggle(windowToggleUI.isOn);
        }
    }
    void HandleWindowToggle(bool on)
    {
        if(on)
        {

            // Switch to full-screen mode
            Screen.fullScreen = true;
            Screen.SetResolution(1920, 1080, true); // Set resolution for fullscreen (optional)
        }
        else
        {

            // Switch to full-screen mode
            Screen.fullScreen = false;
            Screen.SetResolution(1920, 1080, false); // Set resolution for fullscreen (optional)
        }
    }
}
