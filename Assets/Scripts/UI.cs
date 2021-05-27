using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    bool isMuted = false;
    public Sprite mute;
    public Sprite unMute;
    public GameObject soundButton;
    public void ToggleSound()
    {
        isMuted = !isMuted;

        if (isMuted)
        {
            AudioListener.volume = 0f;
            soundButton.GetComponent<Image>().sprite = mute;
        }
        else
        {
            AudioListener.volume = 1f;
            soundButton.GetComponent<Image>().sprite = unMute;
        }

    }

  

    public void LoadScene(int sc)
    {
        SceneManager.LoadScene(sc);
    }

  

}
