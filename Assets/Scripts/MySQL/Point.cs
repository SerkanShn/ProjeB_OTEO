using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Point : MonoBehaviour
{
    public float pointRate;
    public void PointFunc()
    {
        StartCoroutine(PointIE());
    }

    IEnumerator PointIE()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", PlayerPrefs.GetString("username"));
        form.AddField("point", pointRate.ToString());

        UnityWebRequest www = UnityWebRequest.Post("http://oteokou.atwebpages.com/point.php", form);

        yield return www.SendWebRequest();
        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }
        else
        {
            if (www.downloadHandler.text == "0")
            {
                Debug.Log("Gönderme Başarılı");
               
            }
        }
       
    }
}
