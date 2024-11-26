using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

    BattleOutcomesController battleOutcomesController;

    [SerializeField] EventCard evCard;

    [SerializeField] TextMeshProUGUI cardTitle;
    [SerializeField] TextMeshProUGUI cardDescryption;
    [SerializeField] Image cardImage;
    [SerializeField] TextMeshProUGUI totalSuccessText, partialSuccessText, failureText;
    [SerializeField] TextMeshProUGUI totalSuccessOutcomeText, partialSuccessOutcomeText, failureOutcomeText;

    private void Awake()
    {
        battleOutcomesController = GameObject.FindWithTag("Battle_Outcomes_Controller").GetComponent<BattleOutcomesController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(battleOutcomesController)battleOutcomesController.EventStartedSound();
        cardTitle.text = evCard.CardTitle.ToString();
        cardDescryption.text = evCard.CardDescryption.ToString();
        cardImage.sprite = evCard.CardImage;
        totalSuccessText.text = evCard.TotalSuccessText;
        partialSuccessText.text = evCard.PartialSuccessText;
        failureText.text = evCard.FailureText;
        totalSuccessOutcomeText.text = evCard.TotalSuccessOutcomeText;
        partialSuccessOutcomeText.text = evCard.PartialSuccessOutcomeText;
        failureOutcomeText.text = evCard.FailureOutcomeText;

    }
}
