using UnityEngine;
using TMPro;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TextMeshProUGUI pickupText;

    void Awake()
    {
        instance = this;
    }

    public void ShowMessage(string message)
    {
        StopAllCoroutines();
        StartCoroutine(ShowPopup(message));
    }

    IEnumerator ShowPopup(string message)
    {
        pickupText.text = message;

        pickupText.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);

        pickupText.gameObject.SetActive(false);
    }
}