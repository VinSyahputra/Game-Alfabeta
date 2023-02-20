using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jawab : MonoBehaviour
{
    public GameObject partikel, bubble, feedbenar, feedsalah, DataSoal;
    public bool benar;
	private int skor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseUp(){
        partikel.SetActive(true);
        bubble.SetActive(true);

        if(benar){
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

            feedbenar.SetActive(false);
            feedbenar.SetActive(true);

        }else{
            PlayerPrefs.SetInt("hp", PlayerPrefs.GetInt("hp") - 1);

			PlayerPrefs.SetInt("timer", 30);
    		
			
			if(PlayerPrefs.GetInt("hp") == 0){
				PlayerPrefs.SetInt("number", PlayerPrefs.GetInt("number")+1);
                gameObject.SetActive(false);
                DataSoal.GetComponent<DataSoal>().gameover();
			}else{
                feedsalah.SetActive(false);
                feedsalah.SetActive(true);
			}

            
        }

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("timerActive") == 0){
			
			feedsalah.SetActive(false);
            feedsalah.SetActive(true);
			PlayerPrefs.SetInt("hp", PlayerPrefs.GetInt("hp") - 1);

			if(PlayerPrefs.GetInt("hp") == 0){
				gameObject.SetActive(false);
				DataSoal.GetComponent<DataSoal>().gameover();
			}else{
				DataSoal.GetComponent<DataSoal>().control(1);
				PlayerPrefs.SetInt("timer", 30);
				PlayerPrefs.SetInt("timerActive",1);
			}
		}
    }
}
