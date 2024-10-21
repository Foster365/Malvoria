using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialDecisionButton : MonoBehaviour
{
    public void HandleTutorialDecisionButton(string type)
    {
        switch(type)
        {
            case "Total_Success":
                GameManager.Instance.TotalSuccessCount--;
                StartCoroutine(WaitToDisableAndRestore(type));
                break;
            case "Partial_Success":
                GameManager.Instance.PartialSuccessCount--;
                StartCoroutine(WaitToDisableAndRestore(type));
                break;
            case "Failure":
                GameManager.Instance.FailureCount--;
                StartCoroutine(WaitToDisableAndRestore(type));
                break;
        }
    }

    IEnumerator WaitToDisableAndRestore(string type)
    {
        yield return new WaitForSeconds(2);
        transform.parent.gameObject.SetActive(false);
        RestoreInitialDecisionCount(type);
        GameManager.Instance.Player.IsMoving = true;
    }
    void RestoreInitialDecisionCount(string type)
    {
        switch (type)
        {
            case "Total_Success":
                GameManager.Instance.TotalSuccessCount++;
                break;
            case "Partial_Success":
                GameManager.Instance.PartialSuccessCount++;
                break;
            case "Failure":
                GameManager.Instance.FailureCount++;
                break;
        }
    }
}
