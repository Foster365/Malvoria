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

    Player playerReference;

    List<string> battleOutcomesList = new List<string>();

    #region Encapsulated variables
    public List<string> BattleOutcomesList { get => battleOutcomesList; set => battleOutcomesList = value; }
    public TextMeshProUGUI TotalSuccessCountImage { get => totalSuccessCountImage; set => totalSuccessCountImage = value; }
    public TextMeshProUGUI PartialSuccessCountImage { get => partialSuccessCountImage; set => partialSuccessCountImage = value; }
    public TextMeshProUGUI FailureCountImage { get => failureCountImage; set => failureCountImage = value; }
    public Player PlayerReference { get => playerReference; set => playerReference = value; }
    #endregion

    private void Start()
    {
        SortBattleCards();
        playerReference = GameObject.FindWithTag(TagManager.PLAYER_TAG).GetComponent<Player>();
    }

    private void Update()
    {
        totalSuccessCountImage.text = GameManager.Instance.TotalSuccessCount.ToString();
        partialSuccessCountImage.text = GameManager.Instance.PartialSuccessCount.ToString();
        failureCountImage.text = GameManager.Instance.FailureCount.ToString();
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
    public void HandleCardEvent(GameObject eventCard)
    {
        if (eventCard) eventCard.SetActive(true);
    }

    public void HandleDecisionModifiers(int oxygenModifier, int healthModifier, int totalSuccessModifier, int partialSuccessModifier, int failureModifier)
    {
        playerReference.Oxygen+=oxygenModifier;
        playerReference.Health+=healthModifier;
        if (GameManager.Instance.TotalSuccessCount > 0) totalSuccessCount += totalSuccessModifier;
        if (GameManager.Instance.PartialSuccessCount > 0) partialSuccessCount += partialSuccessModifier;
        if (GameManager.Instance.FailureCount > 0) failureCount += failureModifier;

        Debug.Log("Total success count: " + GameManager.Instance.TotalSuccessCount);
    }

    void ValueModifierHandler(int value, int modifier)
    {
        if (value > 0) value += modifier;
    }

    int GetRandomOutcomesValue(int max)
    {
        var value = UnityEngine.Random.Range(1, max);
        return value;
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

    public void DecreaseCardsAmount(string cardType)
    {
        Debug.Log("Tipo de carta: " + cardType);
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
        battleOutcomesList.Remove(value);
    }

    public void DisableCard(GameObject eventCard)
    {
        if (eventCard && playerReference)
        {
            playerReference.IsMoving = true;
            eventCard.gameObject.SetActive(false);
        }
    }
}
