using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasangKata_Skor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("getSkor")){
			PlayerPrefs.SetInt("getSkor", 0);
		}else{
			PlayerPrefs.GetInt("getSkor");
		}
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("getSkor").ToString();
    }
}
