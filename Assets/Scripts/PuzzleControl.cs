using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleControl : MonoBehaviour
{

    public Transform[] pictures;
    public static bool youWin;
    bool isSend = false;
    public AudioClip clip;
    public AudioSource source;
    private void Start()
    {
        youWin = false;
    }

    private void Update()
    {
        if(pictures[0].rotation.z==0&& pictures[1].rotation.z == 0&&
           pictures[2].rotation.z == 0&& pictures[3].rotation.z == 0&&
           pictures[4].rotation.z == 0&& pictures[5].rotation.z == 0&&
           pictures[6].rotation.z == 0&& pictures[7].rotation.z == 0&&
           pictures[8].rotation.z == 0)
        {
            youWin = true;
            if (youWin && !isSend)
            {
                GetComponent<Point>().PointFunc();
                isSend = true;
            }
            source.PlayOneShot(clip);
        }
    }
}
