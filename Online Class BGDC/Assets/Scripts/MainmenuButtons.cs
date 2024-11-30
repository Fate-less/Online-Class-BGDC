using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainmenuButtons : MonoBehaviour, IPointerEnterHandler
{
    public GameObject[] allMenuContents;
    public GameObject menuContent;

    public void OnPointerEnter(PointerEventData eventData)
    {
        for(int i = 0; i < allMenuContents.Length; i++)
        {
            allMenuContents[i].SetActive(false);
        }
        menuContent.SetActive(true);
    }

    
}
