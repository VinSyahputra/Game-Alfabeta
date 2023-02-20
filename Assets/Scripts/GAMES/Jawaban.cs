using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class Jawaban : MonoBehaviour
{
	public GameObject feed_benar, feed_salah, Next;
	private int skor;
	int[] rand = new int[10];
	int index;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void jawaban(bool jawab){
		
    	if(jawab){
			// index= index + 1;
			// PlayerPrefs.SetInt("number", PlayerPrefs.GetInt("number")+1);
    		feed_benar.SetActive (false);
    		feed_benar.SetActive(true);
			

			if(PlayerPrefs.GetInt("timer") >=24){
				skor = PlayerPrefs.GetInt("skor") + 100;
			}
			else if(PlayerPrefs.GetInt("timer") >=14){
				skor = PlayerPrefs.GetInt("skor") + 50;
			}
			else if(PlayerPrefs.GetInt("timer") >=1){
				skor = PlayerPrefs.GetInt("skor") + 10;
			}
    		
    		PlayerPrefs.SetInt("skor", skor);
			PlayerPrefs.SetInt("timer", 30);
    		gameObject.SetActive(false);
			

			// if(PlayerPrefs.GetInt("number") == 20){
			// 	transform.parent.GetChild(transform.parent.childCount - 2 ).gameObject.SetActive(true);
			// }else{

			// transform.parent.GetChild(rand[PlayerPrefs.GetInt("number")]).gameObject.SetActive(true);
			// }
			Next.GetComponent<getChild>().next(1);
    		// transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
			
    	}else{
			// jika jawaban salah
			// Debug.Log(transform.parent.GetChild(gameObject.transform.GetSiblingIndex()));

    		feed_salah.SetActive(false);
    		feed_salah.SetActive(true);
			PlayerPrefs.SetInt("hp", PlayerPrefs.GetInt("hp") - 1);

			PlayerPrefs.SetInt("timer", 30);
    		gameObject.SetActive(false);
			
			if(PlayerPrefs.GetInt("hp") == 0){
				PlayerPrefs.SetInt("number", PlayerPrefs.GetInt("number")+1);
				gameObject.SetActive(false);
				// transform.parent.GetChild(rand[PlayerPrefs.GetInt("number")]).gameObject.SetActive(false);
				transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(false);
				transform.parent.GetChild(transform.parent.childCount - 1 ).gameObject.SetActive(true);
			}else{
				// PlayerPrefs.SetInt("number", PlayerPrefs.GetInt("number")+1);
				// gameObject.SetActive(false);
				// transform.parent.GetChild(rand[PlayerPrefs.GetInt("number")]).gameObject.SetActive(true);
    			// transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
				Next.GetComponent<getChild>().next(1);
			}
			
    	}
		// Debug.Log(PlayerPrefs.GetInt("timer"));
		// PlayerPrefs.SetInt("timer", 30);
    	// gameObject.SetActive(false);
    	// transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
		// jika waktu habis
        if(PlayerPrefs.GetInt("timerActive") == 0){
			
			feed_salah.SetActive(false);
    		feed_salah.SetActive(true);
			
    		gameObject.SetActive(false);
			// Debug.Log(transform.parent.childCount - 1);
			PlayerPrefs.SetInt("hp", PlayerPrefs.GetInt("hp") - 1);

			if(PlayerPrefs.GetInt("hp") == 0){
				
				transform.parent.GetChild(transform.parent.childCount - 1 ).gameObject.SetActive(true);
			}else{
				transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
				PlayerPrefs.SetInt("timer", 30);
				PlayerPrefs.SetInt("timerActive",1);
			}
		}
    }
}
