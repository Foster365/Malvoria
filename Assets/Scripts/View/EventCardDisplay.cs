using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventCardDisplay : MonoBehaviour
{
    [SerializeField] EventCard card;

    [Header("Introduction attributes")]
    [SerializeField] TextMeshProUGUI cardName;
    [SerializeField] TextMeshProUGUI cardDescription;
    [SerializeField] Image artwork;
    [SerializeField] Image cardImage;

    [Header("Decision-making attributes")]
    [SerializeField] TextMeshProUGUI totalSuccessText;
    [SerializeField] TextMeshProUGUI successText;
    [SerializeField] TextMeshProUGUI failureText;
    [SerializeField] DecisionButton totalSuccessButton, successButton, failureButton;

    private void Start()
    {
        DisplayCardData();
    }

    void DisplayCardData()
    {
        cardName.text = card.CardName;
        cardDescription.text = card.CardDescription;
        artwork.sprite = card.Artwork;
        cardImage.sprite = card.CardImage;
        totalSuccessText.text = card.TotalSuccessText;
        successText.text = card.SuccessText;
        failureText.text = card.FailureText;

    }
}
