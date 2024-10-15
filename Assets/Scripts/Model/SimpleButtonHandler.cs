using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleButtonHandler : MonoBehaviour
{
    public void HandleSimpleButton()
    {
        GameManager.Instance.Player.IsMoving = true;
        transform.parent.gameObject.SetActive(false);
    }

    public void HoverSound()
    {
        AudioManager.instance.PlaySFX("Button_Hover");
    }

    public void ClickSound()
    {
        AudioManager.instance.PlaySFX("Button_Click");
    }
}
