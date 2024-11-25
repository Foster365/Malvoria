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
        if(AudioManager.instance && AudioManager.instance.GetSFX("Button_Hover")) AudioManager.instance.PlaySFX("Button_Hover");
    }

    public void ClickSound()
    {
        if(AudioManager.instance && AudioManager.instance.GetSFX("Button_Click")) AudioManager.instance.PlaySFX("Button_Click");
    }
}
