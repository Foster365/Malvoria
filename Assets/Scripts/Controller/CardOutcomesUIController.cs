using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardOutcomesUIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI totalSuccessCountImage, partialSuccessCountImage, failureCountImage;

    void Update()
    {
        totalSuccessCountImage.text = GameManager.Instance.TotalSuccessCount.ToString();
        partialSuccessCountImage.text = GameManager.Instance.PartialSuccessCount.ToString();
        failureCountImage.text = GameManager.Instance.FailureCount.ToString();
    }
}
