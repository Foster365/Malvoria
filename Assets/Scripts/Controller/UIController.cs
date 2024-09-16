using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI oxygenLevel, healthLevel;

    private void Awake()
    {
        oxygenLevel = GameObject.FindWithTag(TagManager.OXYGEN_LEVEL_UI_TAG).GetComponent<TextMeshProUGUI>();
        healthLevel = GameObject.FindWithTag(TagManager.HEALTH_LEVEL_UI_TAG).GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        oxygenLevel.text = $"O2:{GameManager.Instance.Player.Oxygen}%";
        healthLevel.text = $"{GameManager.Instance.Player.Health}";
    }
}
