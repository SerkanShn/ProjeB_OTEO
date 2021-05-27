using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Color", menuName = "Colors/New Color", order = 1)]
public class ColorObject : ScriptableObject
{
    public Colors colorText;
    public Color colorRGB;
    public AudioClip colorClip;

}
