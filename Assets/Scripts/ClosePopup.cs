using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ClosePopup : MonoBehaviour, IPointerDownHandler
{
	public GameObject popup;

    public void OnPointerDown(PointerEventData data)
    {
        LeanTween.scale(popup, new Vector2(0.0f, 0.0f), .5f);
    	// popup.SetActive(false);
    }
 	
 	// public void CloseP()

}
