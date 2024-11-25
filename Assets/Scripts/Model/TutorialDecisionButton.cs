using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TutorialDecisionButton : MonoBehaviour
{

    [SerializeField] Button button;

    private void Update()
    {
        //if(!button.interactable)
        //    transform.parent.gameObject.SetActive(false);
    }

    public void HandleTutorialDecisionButton(string type)
    {
        switch(type)
        {
            case "Total_Success":
                GameManager.Instance.TotalSuccessCount--;
                button.interactable = false;
                StartCoroutine(WaitToDisableAndRestore(type));
                break;
            case "Partial_Success":
                GameManager.Instance.PartialSuccessCount--;
                button.interactable = false;
                StartCoroutine(WaitToDisableAndRestore(type));
                break;
            case "Failure":
                GameManager.Instance.FailureCount--;
                button.interactable = false;
                StartCoroutine(WaitToDisableAndRestore(type));
                break;
        }
    }

    IEnumerator WaitToDisableAndRestore(string type)
    {
        yield return new WaitForSeconds(.15f);
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

    public void HoverSound()
    {
        if(AudioManager.instance && AudioManager.instance.GetSFX("Button_Hover")) AudioManager.instance.PlaySFX("Button_Hover");
    }

    public void ClickSound()
    {
        if(AudioManager.instance && AudioManager.instance.GetSFX("Button_Click")) AudioManager.instance.PlaySFX("Button_Click");
    }
}
