using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{

    [SerializeField] GameObject eventCard;
    Player player;
    bool isVisited;

    public bool IsVisited { get => isVisited; set => isVisited = value; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isVisited = true;
            var player = collision.gameObject.GetComponent<Player>();
            HandleOxygenDecrease(player);
            StartCoroutine(WaitUntilBlockMovement(player));
            Debug.Log("Collision w player");
            HandleCardEvent();
            StartCoroutine(WaitUntilDisablingCard());
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

    IEnumerator WaitUntilDisablingCard()
    {
        yield return new WaitForSeconds(5);
        DisableCard();
    }

    void HandleCardEvent()
    {
        if (eventCard != null) eventCard.SetActive(true);
    }

    public void DisableCard()
    {
        if (eventCard != null && player != null)
        {
            eventCard.SetActive(false);
            player.IsMoving = true;
        }
    }
}
