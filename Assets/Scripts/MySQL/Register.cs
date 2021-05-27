using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public InputField usernameField;
    public InputField passwordField;
    public GameObject registerPanel;
    public GameObject loginPanel;
    public Button registerBtn;
    public void RegisterFunc()
    {
        StartCoroutine(RegisterIE());
    }

    IEnumerator RegisterIE()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", usernameField.text);
        form.AddField("password", passwordField.text);

        UnityWebRequest www = UnityWebRequest.Post("http://oteokou.atwebpages.com/register.php", form);

        yield return www.SendWebRequest();
        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }
        else
        {
            if (www.downloadHandler.text == "0")
            {
                Debug.Log("Kayıt Başarılı");
                usernameField.text = "";
                passwordField.text = "";
                loginPanel.SetActive(true);
                registerPanel.SetActive(false);
            }

        }

    }

    public void Validation()
    {
        registerBtn.interactable = usernameField.text.Length >= 7 && passwordField.text.Length >= 6;
    }
}
