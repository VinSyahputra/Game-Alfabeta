using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.EventSystems;
public class PlaySound : MonoBehaviour, IPointerDownHandler
{
    public List<AudioClip> audioClips;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        AudioClip clip = audioClips[PlayerPrefs.GetInt("number")];
        audioSource.clip = clip;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerDown (PointerEventData eventData) {
    	
        audioSource.Play();
    }
}
