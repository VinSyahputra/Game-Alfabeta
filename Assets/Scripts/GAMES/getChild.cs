using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.EventSystems;
public class getChild : MonoBehaviour
{
    public List<AudioClip> audioClips;
    public AudioSource audioSource;

    int[] arr;
    int urutan = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(transform.childCount-1);
        arr = new int[transform.childCount-2];
        // random pilihan kata
         for (int i = 0; i < transform.childCount - 2 ; i++)
        {
            
            arr[i] = i;
        }
        System.Random random = new System.Random();
        arr = arr.OrderBy(x => random.Next()).ToArray();
		Debug.Log("jumlah :" + arr.Length);
		for (int i = 0; i < arr.Length; i++)
		{
			// Debug.Log(arr[i]);
		}

        //audio
		AudioClip clip = audioClips[arr[urutan]];
        audioSource.clip = clip;
        audioSource.PlayDelayed(2.5f);


        transform.GetChild(arr[urutan]).gameObject.SetActive(true);
    }

    public void next(int x){
        

        if(urutan < arr.Length-1){
            urutan+=x;

            //audio
            AudioClip clip = audioClips[arr[urutan]];
            audioSource.clip = clip;
            audioSource.PlayDelayed(1.2f);

            transform.GetChild(arr[urutan]).gameObject.SetActive(true);
            Debug.Log(urutan);
        }else{
            transform.GetChild(transform.childCount-2).gameObject.SetActive(true);
        }
       
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
