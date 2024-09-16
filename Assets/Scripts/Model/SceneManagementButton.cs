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
}