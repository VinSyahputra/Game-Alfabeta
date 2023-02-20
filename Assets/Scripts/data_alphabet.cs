using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class data_alphabet : MonoBehaviour
{
	int queue = 0;
    // Start is called before the first frame update
    void Start()
    {
        setActive();
    }

    public void control(int i){
    	queue +=i;
    	if(queue > transform.childCount -1){
    		queue = 0;
    	}else if(queue < 0){
    		queue = transform.childCount -1;
    	}
    	setActive();
    }

   public void setActive(){
   	for( int i = 0; i< transform.childCount; i++){
   		transform.GetChild(i).gameObject.SetActive(false);
   	}
   	transform.GetChild(queue).gameObject.SetActive(true);
   } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
