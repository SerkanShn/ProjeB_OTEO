using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberManager : Manager
{
    public NumbersObject[] numbers;
    private void Start()
    {
        UpdateIndex();
    }

    public override void PlaySound()
    {
        source.PlayOneShot(numbers[currentObjectIndex].numberClip);
    }

    public void NextIndex()
    {
        base.NextIndex(numbers);
    }

    public override void UpdateIndex()
    {
        objectText.text = numbers[currentObjectIndex].numberText;
        listenButton.sprite = numbers[currentObjectIndex].numberSprite;
    }
}
