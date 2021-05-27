using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MatchingGameMovement : MonoBehaviour, IDragHandler
{
     Camera cam;
     GameObject[] shadows;
     Vector2 startPos;
    public MatchingGameManager mng;
    private void Start()
    {
        cam = Camera.main;
        shadows = GameObject.FindGameObjectsWithTag("Shadow");
        startPos = transform.position;
    }

    //private void OnMouseDrag()
    //{
    //    Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
    //    pos.z = 0;
    //    transform.position = pos;
    //}

   

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position += (Vector3)eventData.delta;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (var shadow in shadows)
            {
                if (gameObject.name == shadow.name)
                {
                    float distance = Vector3.Distance(shadow.transform.position, transform.position);
                    if (distance <= 30)
                    {
                        transform.position = shadow.transform.position;
                        mng.AddTrueMatching();
                        Destroy(this);
                    }
                    else
                        transform.position = startPos;
                }
            }
        }
    }
}
