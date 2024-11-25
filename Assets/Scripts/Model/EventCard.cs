using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event Card", menuName = "Event Card")]
public class EventCard : ScriptableObject
{
    [SerializeField] string cardTitle;
    [SerializeField] string cardType;
    [SerializeField] string cardDescryption;
    [SerializeField] Sprite cardImage;
    [SerializeField] int oxygenModifier, healthModifier;
    [SerializeField] int totalSuccessModifier, partialSuccessModifier, failureModifier;

    public string CardTitle { get => cardTitle; set => cardTitle = value; }
    public string CardType { get => cardType; set => cardType = value; }
    public string CardDescryption { get => cardDescryption; set => cardDescryption = value; }
    public Sprite CardImage { get => cardImage; set => cardImage = value; }
    public int OxygenModifier { get => oxygenModifier; set => oxygenModifier = value; }
    public int HealthModifier { get => healthModifier; set => healthModifier = value; }
    public int TotalSuccessModifier { get => totalSuccessModifier; set => totalSuccessModifier = value; }
    public int PartialSuccessModifier { get => partialSuccessModifier; set => partialSuccessModifier = value; }
    public int FailureModifier { get => failureModifier; set => failureModifier = value; }
}
