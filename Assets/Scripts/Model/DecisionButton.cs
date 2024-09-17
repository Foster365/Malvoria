using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DecisionButton : MonoBehaviour
{
    [SerializeField] string cardType;
    [SerializeField] BattleOutcomesController controller;
    [SerializeField] int oxygenModifier, healthModifier;
    [SerializeField] int totalSuccessModifier, partialSuccessModifier, failureModifier;

    public void UseCard()
    {
        if(!VerifyValuesBeforeUse())
        {
            controller.HandleDecisionModifiers(oxygenModifier, healthModifier, totalSuccessModifier, partialSuccessModifier, failureModifier);
            controller.DecreaseCardsAmount(cardType);
            controller.RemoveCardsFromList(cardType);
            controller.DisableCard(this.transform.parent.gameObject);
        }
    }

    bool VerifyValuesBeforeUse()
    {
        if (cardType == "Total_Success" && GameManager.Instance.TotalSuccessCount == 0)
        {
            gameObject.GetComponent<Button>().interactable = false;
            return true;
        }
        if (cardType == "Partial_Success" && GameManager.Instance.PartialSuccessCount == 0)
        {
            gameObject.GetComponent<Button>().interactable = false;
            return true;
        }
        if (cardType == "Failure" && GameManager.Instance.FailureCount == 0)
        {
            gameObject.GetComponent<Button>().interactable = false;
            return true;
        }
        else return false;
    }
}
