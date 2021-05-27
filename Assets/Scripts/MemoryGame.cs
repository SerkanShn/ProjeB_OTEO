using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MemoryGame : MonoBehaviour
{
    public Image[] cardHolders;
    public List<Sprite> allCardImages;
    public List<GameObject> selectedCards;
    int currentMatchedCard = 0;
    private void Start()
    {
        for (int i = 0; i < cardHolders.Length; i+=2)
        {
            int random = Random.Range(0, allCardImages.Count);
            cardHolders[i].sprite = allCardImages[random];
            cardHolders[i+1].sprite = allCardImages[random];
            allCardImages.RemoveAt(random);

        }
    }

    public void Back()
    {
        SceneManager.LoadScene(2);
    }

    IEnumerator SelectCardCaroutine(GameObject card)
    {
        if (selectedCards.Count != 2)
        {
            selectedCards.Add(card);
            card.SetActive(true);
        }
        if (selectedCards.Count == 2)
        {
            yield return new WaitForSeconds(0.5f);
            if (selectedCards[0].gameObject.GetComponent<Image>().sprite == selectedCards[1].gameObject.GetComponent<Image>().sprite)
            {
                Destroy(selectedCards[0].transform.parent.gameObject);
                Destroy(selectedCards[1].transform.parent.gameObject);
                selectedCards.Clear();
                currentMatchedCard++;
            }
            else
            {
                selectedCards[0].SetActive(false);
                selectedCards[1].SetActive(false);
                selectedCards.Clear();

            }
        }
        if (currentMatchedCard == 3)
        {
            GetComponent<Point>().PointFunc();
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void SelectCard(GameObject card)
    {
        StartCoroutine(SelectCardCaroutine(card));
    }
}
