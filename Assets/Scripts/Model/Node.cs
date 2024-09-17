using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{

    [SerializeField] GameObject eventCard;
    BattleOutcomesController battleOutcomesController;
    bool isVisited;

    public bool IsVisited { get => isVisited; set => isVisited = value; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            isVisited = true;
            HandleOxygenDecrease(GameManager.Instance.Player);
            GameManager.Instance.Player.IsMoving = false;
            battleOutcomesController = GameObject.FindWithTag(TagManager.BATTLE_OUTCOMES_CONTROLLER_TAG).GetComponent<BattleOutcomesController>();
            if(battleOutcomesController)battleOutcomesController.HandleCardEvent(eventCard);
        }
    }

    void HandleOxygenDecrease(Player player)
    {
        if(gameObject.tag != TagManager.PLAYER_INTRODUCTION_NODE_TAG)player.Oxygen--;
    }

}
