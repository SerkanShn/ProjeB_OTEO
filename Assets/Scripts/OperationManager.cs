
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationManager : MonoBehaviour
{
    public NumbersObject[] numbersList;
    public NumbersObject[] operationsList;
    public AudioSource source;
    public Image firstNumSprite;
    public Image secondNumSprite;
    public Image resultNumSprite;
    public enum OperationType
    {
        Sum,
        Substract,
        Multiply,
        Divide
    }

    public OperationType type;


    void Start()
    {
        Operation();
    }

    public void NextIndex()
    {
        StopAllCoroutines();
        Operation();
    }

    void Operation()
    {
        switch (type)
        {
            case OperationType.Sum:
                Sum();
                break;
            case OperationType.Substract:
                Subtract();
                break;
            case OperationType.Multiply:
                Multiply();
                break;
            case OperationType.Divide:
                Divide();
                break;
            default:
                break;
        }
    }

    IEnumerator CalcSound(AudioClip[] clips)
    {
        yield return new WaitForSeconds(0.7f);
        for (int i = 0; i < 5; i++)
        {
            source.PlayOneShot(clips[i]);
            yield return new WaitForSeconds(0.7f);
        }
    }

    int firstNum;
    int secondNum;
    int resultNum;

    void Sum()
    {
         firstNum = Random.Range(0, 9);
         secondNum = Random.Range(0, (9 - firstNum - 1));
         resultNum = firstNum + secondNum;

        firstNumSprite.sprite = numbersList[firstNum].numberSprite;
        secondNumSprite.sprite = numbersList[secondNum].numberSprite;
        resultNumSprite.sprite = numbersList[resultNum].numberSprite;
        StartCoroutine(CalcSound(new AudioClip[] { numbersList[firstNum].numberClip, operationsList[0].numberClip, numbersList[secondNum].numberClip,operationsList[1].numberClip, numbersList[resultNum].numberClip }));
    }

    void Subtract()
    {
         firstNum = Random.Range(0, 9);
         secondNum = Random.Range(0, firstNum);
        resultNum = firstNum - secondNum;

        firstNumSprite.sprite = numbersList[firstNum].numberSprite;
        secondNumSprite.sprite = numbersList[secondNum].numberSprite;
        resultNumSprite.sprite = numbersList[resultNum].numberSprite;
        StartCoroutine(CalcSound(new AudioClip[] { numbersList[firstNum].numberClip, operationsList[0].numberClip, numbersList[secondNum].numberClip, operationsList[1].numberClip, numbersList[resultNum].numberClip }));

    }

    void Multiply()
    {
         firstNum = Random.Range(1, 9);
         secondNum = Random.Range(0, (9 / firstNum));
        resultNum = firstNum * secondNum;


        firstNumSprite.sprite = numbersList[firstNum].numberSprite;
        secondNumSprite.sprite = numbersList[secondNum].numberSprite;
        resultNumSprite.sprite = numbersList[resultNum].numberSprite;
        StartCoroutine(CalcSound(new AudioClip[] { numbersList[firstNum].numberClip, operationsList[0].numberClip, numbersList[secondNum].numberClip, operationsList[1].numberClip, numbersList[resultNum].numberClip }));

    }

    void Divide()
    {
         firstNum = Random.Range(1, 9);
        List<int> temp = new List<int>();
        print(firstNum);
        for (int i = 1; i <= firstNum; i++)
        {
            if (firstNum % i == 0)
                temp.Add(i);
        }
         secondNum = temp[Random.Range(0, temp.Count)];
        resultNum = firstNum / secondNum;
        print(secondNum);
        firstNumSprite.sprite = numbersList[firstNum].numberSprite;
        secondNumSprite.sprite = numbersList[secondNum].numberSprite;
        resultNumSprite.sprite = numbersList[resultNum].numberSprite;
        StartCoroutine(CalcSound(new AudioClip[] { numbersList[firstNum].numberClip, operationsList[0].numberClip, numbersList[secondNum].numberClip, operationsList[1].numberClip, numbersList[resultNum].numberClip }));

    }

}
