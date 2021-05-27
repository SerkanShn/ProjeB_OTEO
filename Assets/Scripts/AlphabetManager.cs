using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AlphabetManager : Manager
{
    public AlphabetObject[] alphabetChars;

    private void Start()
    {
        UpdateIndex();
    }

    public override void PlaySound()
    {
        source.PlayOneShot(alphabetChars[currentObjectIndex].charClip);
    }

    public void NextIndex()
    {
        base.NextIndex(alphabetChars);
    }

   

    public override void UpdateIndex()
    {
        listenButton.sprite = alphabetChars[currentObjectIndex].charSprite;
    }
}
