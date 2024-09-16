using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionButton : MonoBehaviour
{
    [SerializeField] string cardType;
    [SerializeField] BattleOutcomesController controller;
    [SerializeField] int oxygenModifier, healthModifier;
    [SerializeField] int totalSuccessModifier, partialSuccessModifier, failureModifier;

    private void Awake()
    {
        VerifyValuesBeforeUse();
    }

    public void UseCard()
    {
        controller.DecreaseCardsAmount(cardType);
        controller.RemoveCardsFromList(cardType);
        controller.HandleDecisionModifiers(oxygenModifier, healthModifier, totalSuccessModifier, partialSuccessModifier, failureModifier);
        controller.DisableCard(this.transform.parent.gameObject);
    }

    void VerifyValuesBeforeUse()
    {
        if(cardType == "Total_Success" && GameManager.Instance.TotalSuccessCount == 0) gameObject.SetActive(false);
        if (cardType == "Partial_Success" && GameManager.Instance.PartialSuccessCount == 0) gameObject.SetActive(false);
        if (cardType == "Failure" && GameManager.Instance.FailureCount == 0) gameObject.SetActive(false);
    }
}
