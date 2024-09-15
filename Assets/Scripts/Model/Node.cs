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
            player = collision.gameObject.GetComponent<Player>();
            HandleOxygenDecrease(player);
            StartCoroutine(WaitUntilBlockMovement(player));
            HandleCardEvent();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && player)
        {
            DisableCard();
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

    void HandleCardEvent()
    {
        if (eventCard) eventCard.SetActive(true);
    }

    public void DisableCard()
    {
        if (eventCard && player)
        {
            player.IsMoving = true;
            eventCard.SetActive(false);
        }
    }
}
