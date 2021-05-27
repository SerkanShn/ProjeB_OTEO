using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Number", menuName = "Numbers/New Number", order = 1)]

public class NumbersObject : ScriptableObject
{
    public string numberText;
    public Sprite numberSprite;
    public AudioClip numberClip;
}
