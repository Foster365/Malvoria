using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Event Card", menuName ="Event Cards")]
public class EventCard : ScriptableObject
{
    [Header("Introduction attributes")]
    [SerializeField] string cardName;
    [SerializeField] string cardType;
    [SerializeField] string cardDescription;

    [SerializeField] Sprite artwork;
    [SerializeField] Sprite cardImage;

    [Header("Decision-making attributes")]
    [SerializeField] string totalSuccessText;
    [SerializeField] string successText;
    [SerializeField] string failureText;

    [Header("Stats Modifiers")]
    [SerializeField] int oxygenModifier;
    [SerializeField] int healthModifier;
    [SerializeField] int totalSuccessModifier;
    [SerializeField] int successModifier;
    [SerializeField] int failureModifier;

    public string CardName { get => cardName; set => cardName = value; }
    public string CardDescription { get => cardDescription; set => cardDescription = value; }
    public string CardType { get => cardType; set => cardType = value; }
    public Sprite Artwork { get => artwork; set => artwork = value; }
    public Sprite CardImage { get => cardImage; set => cardImage = value; }
    public string TotalSuccessText { get => totalSuccessText; set => totalSuccessText = value; }
    public string SuccessText { get => successText; set => successText = value; }
    public string FailureText { get => failureText; set => failureText = value; }
}
