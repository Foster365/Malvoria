using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDisplay : MonoBehaviour
{

    [SerializeField] EventCard evCard;

    string cardTitle;
    string cardType;
    string cardDescryption;
    Sprite cardImage;
    int oxygenModifier, healthModifier;
    int totalSuccessModifier, partialSuccessModifier, failureModifier;

    // Start is called before the first frame update
    void Start()
    {
        cardTitle = evCard.CardTitle;
        cardType = evCard.CardType;
        cardDescryption = evCard.CardDescryption;
        cardImage = evCard.CardImage;
        oxygenModifier = evCard.OxygenModifier;
        healthModifier = evCard.HealthModifier;
        totalSuccessModifier = evCard.TotalSuccessModifier;
        partialSuccessModifier = evCard.PartialSuccessModifier;
        failureModifier = evCard.FailureModifier;
    }

}
