using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{

    [SerializeField] GameObject eventCard;
    BattleOutcomesController battleOutcomesController;
    bool isVisited;
    Animator anim;

    public bool IsVisited { get => isVisited; set => isVisited = value; }

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == TagManager.PLAYER_TAG)
        {

            isVisited = true; 
            anim.enabled = false;
            GameManager.Instance.Player.IsMoving = false;
            battleOutcomesController = GameObject.FindWithTag(TagManager.BATTLE_OUTCOMES_CONTROLLER_TAG).GetComponent<BattleOutcomesController>();
            if(battleOutcomesController && eventCard)battleOutcomesController.HandleCardEvent(eventCard);
            HandleOxygenDecrease(GameManager.Instance.Player);
            gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
        }
    }

    void HandleOxygenDecrease(Player player)
    {
        if(gameObject.tag != TagManager.PLAYER_INTRODUCTION_NODE_TAG)   player.Oxygen--;
    }

}
