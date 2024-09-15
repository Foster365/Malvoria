using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{

    [SerializeField] GameObject eventCard;
    BattleOutcomesController battleOutcomesController;
    Player player;
    bool isVisited;

    public bool IsVisited { get => isVisited; set => isVisited = value; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            isVisited = true;
            player = collision.gameObject.GetComponent<Player>();
            HandleOxygenDecrease(player);
            StartCoroutine(WaitUntilBlockMovement(player));
            battleOutcomesController = GameObject.FindWithTag(TagManager.BATTLE_OUTCOMES_CONTROLLER_TAG).GetComponent<BattleOutcomesController>();
            if(battleOutcomesController)battleOutcomesController.HandleCardEvent(eventCard);
        }
    }

    void HandleOxygenDecrease(Player player)
    {
        player.Oxygen--;
    }
    IEnumerator WaitUntilBlockMovement(Player player)
    {
        yield return new WaitForSeconds(1);
        player.IsMoving = false;
    }

}
