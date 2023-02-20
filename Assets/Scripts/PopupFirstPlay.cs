using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupFirstPlay : MonoBehaviour
{
	public bool firstRun = false;
	public GameObject popup;
    // Start is called before the first frame update
    public void Awake()
    {
    	if(!PlayerPrefs.HasKey("savedFirstRun")){
        	PlayerPrefs.SetInt("savedFirstRun", 0);
        	LeanTween.scale(popup, new Vector2(1.0f, 1.0f), 0.0f);
        }else{
        	Load();
        }
   //      firstRun = PlayerPrefs.GetInt("savedFirstRun") ;
 
 
 		// if (firstRun == false) // remember "==" for comparing, not "=" which assigns value
 		// {
 		// 	LeanTween.scale(popup, new Vector2(1.0f, 1.0f), 0.0f);
 		// 	// popup.transform.localScale = new Vector2(1.0f, 1.0f);
   // 			firstRun = 1;
 		// }else{
 		// 	LeanTween.scale(popup, new Vector2(0.0f, 0.0f), 0.0f);
 		// }

 		// Debug.Log(firstRun);
    }

    private void Load(){
    	firstRun = PlayerPrefs.GetInt("savedFirstRun") == 1;
    	LeanTween.scale(popup, new Vector2(0.0f, 0.0f), 0.0f);
    }
    private void Save(){
		PlayerPrefs.SetInt("savedFirstRun", firstRun ? 1 : 0);
	}
}
