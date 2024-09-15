using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI oxygenLevel, healthLevel;
    Player player;

    private void Awake()
    {
        oxygenLevel = GameObject.FindWithTag(TagManager.OXYGEN_LEVEL_UI_TAG).GetComponent<TextMeshProUGUI>();
        healthLevel = GameObject.FindWithTag(TagManager.HEALTH_LEVEL_UI_TAG).GetComponent<TextMeshProUGUI>();
        player = GameObject.FindWithTag(TagManager.PLAYER_TAG).GetComponent<Player>();
    }

    private void Update()
    {
        oxygenLevel.text = $"O2:{player.Oxygen}%";
        healthLevel.text = $"{player.Health}";
    }
}
