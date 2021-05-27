using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class Manager : MonoBehaviour
{
    public int currentObjectIndex = 0;
    public TextMeshProUGUI objectText;
    public Image listenButton;
    public AudioSource source;
    public GameObject previousBtn;
    public GameObject nextBtn;

    public virtual void PlaySound()
    {
        source.PlayOneShot(null);
    }

    public virtual void NextIndex(object[] objects)
    {
        if (currentObjectIndex < objects.Length - 1)
        {
            currentObjectIndex++;
            UpdateIndex();
            previousBtn.SetActive(true);

        }


        if (currentObjectIndex == objects.Length - 1)
        {
            nextBtn.SetActive(false);

        }

    }

    public virtual void PreviousIndex()
    {
        if (currentObjectIndex > 0)
        {
            currentObjectIndex--;
            UpdateIndex();
            nextBtn.SetActive(true);

        }

        if (currentObjectIndex == 0)
        {
            previousBtn.SetActive(false);
        }

    }

    public abstract void UpdateIndex();
}
