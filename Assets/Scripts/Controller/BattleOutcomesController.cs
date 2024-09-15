using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleOutcomesController : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI totalSuccessCountImage, partialSuccessCountImage, failureCountImage;
    int totalSuccessCount, partialSuccessCount, failureCount;

    List<string> battleOutcomesList = new List<string>();

    public List<string> BattleOutcomesList { get => battleOutcomesList; set => battleOutcomesList = value; }
    public TextMeshProUGUI TotalSuccessCountImage { get => totalSuccessCountImage; set => totalSuccessCountImage = value; }
    public TextMeshProUGUI PartialSuccessCountImage { get => partialSuccessCountImage; set => partialSuccessCountImage = value; }
    public TextMeshProUGUI FailureCountImage { get => failureCountImage; set => failureCountImage = value; }

    private void Start()
    {
        SortBattleCards();
    }

    public void SortBattleCards()
    {
        SetCardsToDictionary("Total_Success", 3);
        SetCardsToDictionary("Partial_Success", 4);
        SetCardsToDictionary("Failure", 3);
    }

    void SetCardsToDictionary(string typeOfCard, int maxAmountOfCards)
    {
        var amountOfCards = GetRandomOutcomesValue(maxAmountOfCards);
        HandleOutcomesCountUI(typeOfCard, maxAmountOfCards);
        for (int i = 0; i < amountOfCards; i++)
        {
            battleOutcomesList.Add(typeOfCard);
        }
    }
    void HandleOutcomesCountUI(string cardType, int amount)
    {
        switch (cardType)
        {
            case "Total_Success":
                totalSuccessCountImage.text = amount.ToString(); 
                GameManager.Instance.TotalSuccessCount = amount;
                break;
            case "Partial_Success":
                partialSuccessCountImage.text = amount.ToString();
                GameManager.Instance.PartialSuccessCount = amount;
                break;
            case "Failure":
                failureCountImage.text = amount.ToString(); 
                GameManager.Instance.FailureCount = amount;
                break;
        }
    }
    int GetRandomOutcomesValue(int max)
    {
        return UnityEngine.Random.Range(1, max);
    }

    public void RemoveCardsFromList(string value)
    {
        foreach (var c in battleOutcomesList)
        {
            if (c == value)
            {
                Debug.Log("valor es: " + c);
                break;
            }
        }
        //for (int i = 0;i < battleOutcomesList.Count;i++) {
        //    if (battleOutcomesList[i] == value)
        //    {
        //        battleOutcomesList.RemoveAt(i);
        //    }
        //}
    }
}
