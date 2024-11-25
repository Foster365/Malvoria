using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

    [SerializeField] EventCard evCard;

    [SerializeField] TextMeshProUGUI cardTitle;
    [SerializeField] TextMeshProUGUI cardDescryption;
    [SerializeField] Sprite cardImage;
    [SerializeField] TextMeshProUGUI totalSuccessText, partialSuccessText, failureText;
    [SerializeField] TextMeshProUGUI totalSuccessOutcomeText, partialSuccessOutcomeText, failureOutcomeText;
    // Start is called before the first frame update
    void Start()
    {
        cardTitle.text = evCard.CardTitle.ToString();
        cardDescryption.text = evCard.CardDescryption.ToString();
        cardImage = evCard.CardImage;
        totalSuccessText.text = evCard.TotalSuccessText;
        partialSuccessText.text = evCard.PartialSuccessText;
        failureText.text = evCard.FailureText;
        totalSuccessOutcomeText.text = evCard.TotalSuccessOutcomeText;
        partialSuccessOutcomeText.text = evCard.PartialSuccessOutcomeText;
        failureOutcomeText.text = evCard.FailureOutcomeText;

    }
}
