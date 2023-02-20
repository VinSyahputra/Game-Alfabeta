using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class popUpCheck : MonoBehaviour, IPointerDownHandler
// , IPointerUpHandler
{
	public GameObject popup;

    public void OnPointerDown(PointerEventData data)
    {
        //Do the thing when button pressed
        // Debug.Log("Button pressed!");
        // popup.SetActive(true);
        LeanTween.scale(popup, new Vector2(1.0f, 1.0f), .5f);
    }


    // public void OnPointerUp(PointerEventData data)
    // {
    //     //Do the thing when button released
    //     Debug.Log("Button released!");
    // }


}
