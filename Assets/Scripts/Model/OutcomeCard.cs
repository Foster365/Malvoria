using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OutcomeCard : MonoBehaviour
{
    [SerializeField] string cardType;
    [SerializeField] BattleOutcomesController controller;


    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            DecreaseCardsAmount();
            controller.RemoveCardsFromList(cardType);
        }
    }

    void DecreaseCardsAmount()
    {
        switch (cardType)
        {
            case "Total_Success":
                GameManager.Instance.TotalSuccessCount--;
                Debug.Log("total success cards left: " + GameManager.Instance.TotalSuccessCount);
                break;
            case "Partial_Success":
                GameManager.Instance.PartialSuccessCount--;
                Debug.Log("partial success cards left: " + GameManager.Instance.PartialSuccessCount);
                break;
            case "Failure":
                GameManager.Instance.FailureCount--;
                                Debug.Log("failure cards left: " + GameManager.Instance.FailureCount);
                break;
        }
    }
}
