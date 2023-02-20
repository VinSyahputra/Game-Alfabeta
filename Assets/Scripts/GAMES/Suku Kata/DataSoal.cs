using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq; //orderBy library
public class DataSoal : MonoBehaviour
{
    public GameObject hasil_bermain, hasil_bermain_gagal;
    int[] arr;
    int urutan = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.childCount);
        arr = new int[transform.childCount];

        // random pilihan kata
         for (int i = 0; i < transform.childCount; i++)
        {
            // Debug.Log(i);
            arr[i] = i;
        }
        System.Random random = new System.Random();
        arr = arr.OrderBy(x => random.Next()).ToArray();
		Debug.Log("jumlah :" + arr.Length);
		for (int i = 0; i < arr.Length; i++)
		{
			Debug.Log(arr[i]);
		}

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
            transform.GetChild(arr[urutan]).gameObject.SetActive(true);
        // set_ufo();
    }

    public void control(int i){
        transform.GetChild(arr[urutan]).gameObject.SetActive(false);
        if(urutan < transform.childCount){
            
            urutan+=i;
        }
        
        set_ufo();
    }

    public void set_ufo(){
        
        if(urutan < transform.childCount){

            transform.GetChild(arr[urutan]).gameObject.SetActive(true);
        }else{
            transform.GetChild(arr[urutan-2]).gameObject.SetActive(false);
            hasil_bermain.SetActive(true);
        }
    }

    public void gameover(){
        transform.GetChild(arr[urutan]).gameObject.SetActive(false);
        hasil_bermain_gagal.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
