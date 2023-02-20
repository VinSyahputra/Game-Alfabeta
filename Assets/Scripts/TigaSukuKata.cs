using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigaSukuKata : MonoBehaviour
{
	private Animator animator;
	
    // Start is called before the first frame update
    void Awake()
    {
   //  	animator = GetComponent<Animator>();

   //       if (animator.GetCurrentAnimatorStateInfo(0).IsName("3SukuKata"))
		 // {
		 //    animator.enabled = false;
		 // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){ 
    	animator = GetComponent<Animator>();
    	animator.Play("3SukuKata");
    	GetComponent<AudioSource>().Play();
    }
}
