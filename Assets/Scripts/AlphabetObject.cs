using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Alphabet", menuName = "Alphabet/New Character", order = 1)]
public class AlphabetObject : ScriptableObject
{
    public AudioClip charClip;
    public Sprite charSprite;

}
