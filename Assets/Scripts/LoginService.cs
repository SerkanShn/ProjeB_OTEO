using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class LoginService : MonoBehaviour
{
    //public InputField regusernameField;
    //public InputField regpasswordField;
    //public InputField loginusernameField;
    //public InputField loginpasswordField;
    //public void Register()
    //{
    //    StartCoroutine(RegisterIE());
    //}

    //public void Login()
    //{
    //    StartCoroutine(LoginIE());
    //}

    //IEnumerator RegisterIE()
    //{
    //    WWWForm form = new WWWForm();
    //    form.AddField("username", usernameField.text);
    //    form.AddField("password", passwordField.text);

    //    UnityWebRequest www = UnityWebRequest.Post("http://oteokou.atwebpages.com/register.php", form);
        
    //    yield return www.SendWebRequest();
    //    if (www.isNetworkError)
    //    {
    //        Debug.Log(www.error);
    //    }
    //    else
    //    {
    //        if (www.downloadHandler.text == "0")
    //            Debug.Log("Kayıt Başarılı");

    //    }

    //}

    //IEnumerator LoginIE()
    //{
    //    WWWForm form = new WWWForm();
    //    form.AddField("username", usernameField.text);
    //    form.AddField("password", passwordField.text);

    //    UnityWebRequest www = UnityWebRequest.Post("http://koumrkt.dx.am/login.php", form);

    //    yield return www.SendWebRequest();
    //    if (www.isNetworkError)
    //    {
    //        Debug.Log(www.error);
    //    }
    //    else
    //    {
    //        if(www.downloadHandler.text=="0")
    //        Debug.Log("Giriş Başarılı");

    //    }

    //}
}
