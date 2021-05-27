using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MatchingGameManager : MonoBehaviour
{
    public List<Sprite> allImages;
    public Image[] images;
    public Image[] shadows;
    int currentTrueMatching;

    private void Start()
    {
        ShuffleImages();
        currentTrueMatching = 0;
    }

    public void Back()
    {
        SceneManager.LoadScene(2);
    }

    public void AddTrueMatching()
    {
        currentTrueMatching++;
        if (currentTrueMatching == images.Length)
        {
            GetComponent<Point>().PointFunc();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

    void ShuffleImages()
    {
        for (int i = 0; i < images.Length; i++)
        {
            int random = Random.Range(0, allImages.Count);
            images[i].sprite = allImages[random];
            shadows[i].sprite = allImages[random];
            allImages.RemoveAt(random);
        }
    }

}
