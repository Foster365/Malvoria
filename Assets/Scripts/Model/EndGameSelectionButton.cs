using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameSelectionButton : MonoBehaviour
{

    BattleOutcomesController battleOutcomesController;

    private void Awake()
    {
        battleOutcomesController = GameObject.FindWithTag("Battle_Outcomes_Controller").GetComponent<BattleOutcomesController>();
    }

    public void SetWinLevelBoolean()
    {
        GameManager.Instance.IsWin = true;
        battleOutcomesController.EventCompletedSound();
    }

    public void HoverSound()
    {
        if(AudioManager.instance.GetSFX("Button_Hover")) AudioManager.instance.PlaySFX("Button_Hover");
    }

    public void ClickSound()
    {
        if(AudioManager.instance.GetSFX("Button_Click")) AudioManager.instance.PlaySFX("Button_Click");
    }

}
