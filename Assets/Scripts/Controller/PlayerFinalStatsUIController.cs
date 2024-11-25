using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerFinalStatsUIController : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI oxygenLevel, healthLevel;
    [SerializeField] TextMeshProUGUI totalSuccessCount, partialSuccessCount, failureCount;
    [SerializeField] TextMeshProUGUI exploredNodesCount;

    // Start is called before the first frame update
    void Start()
    {
        oxygenLevel.text = $"{GameManager.Instance.Player.Oxygen.ToString()}%";
        healthLevel.text = GameManager.Instance.Player.Health.ToString();
        totalSuccessCount.text = GameManager.Instance.TotalSuccessCount.ToString();
        partialSuccessCount.text = GameManager.Instance.PartialSuccessCount.ToString();
        failureCount.text = GameManager.Instance.FailureCount.ToString();
        exploredNodesCount.text = GameManager.Instance.ExploredNodesCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
