using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManagement : MonoBehaviour
{
	[SerializeField] Image BtnSoundOn;
	[SerializeField] Image BtnSoundOff;
	private bool muted = false;
	// public GameObject sound;
    // Start is called before the first frame update
    void Start()
    {
		// pengaturan untuk game pasang kata
		PlayerPrefs.SetInt("number", 0);
		PlayerPrefs.SetInt("getSkor", 0);

        if(!PlayerPrefs.HasKey("muted")){
        	PlayerPrefs.SetInt("muted", 0);
        }else{
        	Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
		// sound.GetComponent<AudioSource>().Pause();
    }

	public void OnButtonPress(){
		if(muted == false){
			muted = true;
			AudioListener.pause = true;
			// sound.GetComponent<AudioSource>().Pause();
			
		}else{
			muted = false;
			AudioListener.pause = false;
			// sound.GetComponent<AudioSource>().UnPause();
		}
		Save();
		UpdateButtonIcon();
	}

	private void UpdateButtonIcon(){
		if(muted == false){
			BtnSoundOn.enabled = true;
			BtnSoundOff.enabled = false;
		}else{
			BtnSoundOn.enabled = false;
			BtnSoundOff.enabled = true;
		}
	}

	private void Load(){
		muted = PlayerPrefs.GetInt("muted") == 1;
	}

	private void Save(){
		PlayerPrefs.SetInt("muted", muted ? 1 : 0);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
