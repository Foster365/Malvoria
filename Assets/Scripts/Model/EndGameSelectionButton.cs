using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameSelectionButton : MonoBehaviour
{
    public void SetWinLevelBoolean()
    {
        GameManager.Instance.IsWin = true;
    }
}
