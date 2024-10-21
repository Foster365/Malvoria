using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameSelectionButton : MonoBehaviour
{
    public void SetWinLevelBoolean()
    {
        GameManager.Instance.IsWin = true;
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
