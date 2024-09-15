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
        SetCardsToList("Total_Success", GetRandomOutcomesValue(3));
        SetCardsToList("Partial_Success", GetRandomOutcomesValue(4));
        SetCardsToList("Failure", GetRandomOutcomesValue(3));
    }

    void SetCardsToList(string typeOfCard, int amountOfCards)
    {
        HandleOutcomesCountUI(typeOfCard, amountOfCards);
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
                GameManager.Instance.TotalSuccessCount = amount;
                totalSuccessCountImage.text = amount.ToString(); 
                break;
            case "Partial_Success":
                GameManager.Instance.PartialSuccessCount = amount;
                partialSuccessCountImage.text = amount.ToString();
                break;
            case "Failure":
                GameManager.Instance.FailureCount = amount;
                failureCountImage.text = amount.ToString(); 
                break;
        }
    }
    int GetRandomOutcomesValue(int max)
    {
        var value = UnityEngine.Random.Range(1, max);
        return value;
    }

    public void DecreaseCardsAmount(string cardType)
    {
        switch (cardType)
        {
            case "Total_Success":
                GameManager.Instance.TotalSuccessCount--;
                HandleOutcomesCountUI(cardType, GameManager.Instance.TotalSuccessCount);
                break;
            case "Partial_Success":
                GameManager.Instance.PartialSuccessCount--;
                HandleOutcomesCountUI(cardType, GameManager.Instance.PartialSuccessCount);
                break;
            case "Failure":
                GameManager.Instance.FailureCount--;
                HandleOutcomesCountUI(cardType, GameManager.Instance.FailureCount);
                break;
        }
    }

    public void RemoveCardsFromList(string value)
    {
        bool removed = battleOutcomesList.Remove(value);
    }
}
