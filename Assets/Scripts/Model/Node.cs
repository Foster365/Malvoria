using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    [SerializeField]
    GameObject[] eventCards;
    [SerializeField] GameObject eventCard;
    BattleOutcomesController battleOutcomesController;
    bool isVisited;

    public bool IsVisited { get => isVisited; set => isVisited = value; }

    private void Awake()
    {
        battleOutcomesController = GameObject.FindWithTag(TagManager.BATTLE_OUTCOMES_CONTROLLER_TAG).GetComponent<BattleOutcomesController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            isVisited = true;
            gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
            HandleOxygenDecrease(GameManager.Instance.Player);
            GameManager.Instance.Player.IsMoving = false;
<<<<<<< Updated upstream
            battleOutcomesController = GameObject.FindWithTag(TagManager.BATTLE_OUTCOMES_CONTROLLER_TAG).GetComponent<BattleOutcomesController>();
            if(battleOutcomesController)battleOutcomesController.HandleCardEvent(eventCard);
=======


            if (battleOutcomesController && eventCards.Length>0) HandleCardEvents();

            //if(battleOutcomesController && eventCard)battleOutcomesController.HandleCardEvent(eventCard);
        }
    }

    void HandleCardEvents()
    {
        foreach (var card in eventCards)
        {
            battleOutcomesController.HandleCardEvent(card);
>>>>>>> Stashed changes
        }
    }

    void HandleOxygenDecrease(Player player)
    {
        if(gameObject.tag != TagManager.PLAYER_INTRODUCTION_NODE_TAG)player.Oxygen--;
    }

}
