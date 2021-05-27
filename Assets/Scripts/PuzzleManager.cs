using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    public GameObject[] puzzles;
    
    public void Back()
    {
        SceneManager.LoadScene(2);
    }

     void Start()
    {
        puzzles[Random.Range(0, puzzles.Length)].SetActive(true);
    }
}
