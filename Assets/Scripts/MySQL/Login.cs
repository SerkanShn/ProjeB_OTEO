using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField usernameField;
    public InputField passwordField;

    public void LoginFunc()
    {
        StartCoroutine(LoginIE());
    }

    IEnumerator LoginIE()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", usernameField.text);
        form.AddField("password", passwordField.text);

        UnityWebRequest www = UnityWebRequest.Post("http://oteokou.atwebpages.com/login.php", form);

        yield return www.SendWebRequest();
        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }
        else
        {
            if (www.downloadHandler.text == "0")
            {
                Debug.Log("Giriş Başarılı");
                PlayerPrefs.SetString("username", usernameField.text);
                if(PlayerPrefs.GetInt("isSettingsSet")==1)
                SceneManager.LoadScene(2);
                else
                SceneManager.LoadScene(1);

            }
        }
        usernameField.text = "";
        passwordField.text = "";
    }

}
