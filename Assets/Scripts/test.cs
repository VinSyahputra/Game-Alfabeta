using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
	void OnMouseDown(){
    	GetComponent<AudioSource>().Play();
    	// transform.localScale = new Vector2(x * 1.2f, y/1.2f);
    	Debug.Log("clicked");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
