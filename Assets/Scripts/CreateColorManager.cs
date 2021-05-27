using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateColorManager : Manager
{
    public CreatedColorObject[] colors;
    public Animator anim;
    public Image animTopImage;
    public Image animBottomImage;

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
        animTopImage.color = colors[currentObjectIndex].anaRenkler[0];
        animBottomImage.color = colors[currentObjectIndex].anaRenkler[1];
        anim.Play("CreatingColors", -1, 0f);
        objectText.text = colors[currentObjectIndex].colorText.ToString();
        listenButton.color = colors[currentObjectIndex].colorRGB;
    }
}
