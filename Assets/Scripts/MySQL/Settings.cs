using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public InputField ageField;
    public InputField wordField;
    public InputField minField;

    public void SettingsFunc()
    {
        StartCoroutine(SettingsIE());
    }

    IEnumerator SettingsIE()
    {
        WWWForm form = new WWWForm();
        form.AddField("age", ageField.text);
        form.AddField("word", wordField.text);
        form.AddField("min", minField.text);
        form.AddField("username", PlayerPrefs.GetString("username"));


        UnityWebRequest www = UnityWebRequest.Post("http://oteokou.atwebpages.com/settings.php", form);

        yield return www.SendWebRequest();
        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }
        else
        {

            print(www.downloadHandler.text);
            if (www.downloadHandler.text == "0")
            {
                Debug.Log("Ayarlar Başarılı");
                PlayerPrefs.SetInt("isSettingsSet", 1);
                SceneManager.LoadScene(2);
            }
        }
      
    }

}
