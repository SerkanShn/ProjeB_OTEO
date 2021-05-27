using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class CheckDailyPoint : MonoBehaviour
{
    public TextMeshProUGUI dailyPointText;

    private void Awake()
    {
        StartCoroutine(CheckPoint());
    }
    IEnumerator CheckPoint()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", PlayerPrefs.GetString("username"));

        UnityWebRequest www = UnityWebRequest.Post("http://oteokou.atwebpages.com/checkdailypoint.php", form);

        yield return www.SendWebRequest();
        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }
        else
        {
            int temp = Convert.ToInt32(www.downloadHandler.text);
            dailyPointText.text = "Günlük Kalan Puan Hedefi: " + (temp < 0 ? 0: temp);
        }

    }
}
