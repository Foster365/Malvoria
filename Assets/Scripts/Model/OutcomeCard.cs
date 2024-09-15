using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OutcomeCard : MonoBehaviour
{
    [SerializeField] string cardType;
    [SerializeField] BattleOutcomesController controller;

    public void UseCard()
    {
        controller.DecreaseCardsAmount(cardType);
        controller.RemoveCardsFromList(cardType);
    }
}
