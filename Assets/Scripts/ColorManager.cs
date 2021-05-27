using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : Manager
{
    public ColorObject[] colors;



    private void Start()
    {
        UpdateIndex();
    }

    public override void PlaySound()
    {
        source.PlayOneShot(colors[currentObjectIndex].colorClip);
    }

    public void NextIndex()
    {
        base.NextIndex(colors);

    }

    public override void UpdateIndex()
    {
        objectText.text = colors[currentObjectIndex].colorText.ToString();
        listenButton.color = colors[currentObjectIndex].colorRGB;
    }
}
