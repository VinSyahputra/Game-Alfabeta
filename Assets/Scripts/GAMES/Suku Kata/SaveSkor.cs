using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSkor : MonoBehaviour
{
    private int jumlah;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown(){
    	jumlah = PlayerPrefs.GetInt("totalSkor") + PlayerPrefs.GetInt("skor");
        PlayerPrefs.SetInt("totalSkor", jumlah);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
