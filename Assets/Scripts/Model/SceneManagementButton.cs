using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagementButton : MonoBehaviour
{
    [SerializeField] string scene;

    public void HandleScene()
    {
        SceneManager.LoadScene(scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void HoverSound()
    {
        if(AudioManager.instance)AudioManager.instance.PlaySFX("Button_Hover");
    }

    public void ClickSound()
    {
        if(AudioManager.instance)AudioManager.instance.PlaySFX("Button_Click");
    }

}
