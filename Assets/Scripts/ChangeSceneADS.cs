using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneADS : MonoBehaviour
{
    int scene;
    public GameObject Intersitial;
    public void MoveToScene(int sceneID){
        scene = sceneID;
        int randomNumber = Random.Range(0, 2);
        if(randomNumber == 0){
            Intersitial.GetComponent<Intersitial>().intersitial();
        }else{
            SceneManager.LoadScene(scene);
        }

    //     if(Intersitial.GetComponent<Intersitial>().OnAdClosed()){
   	// 	SceneManager.LoadScene(sceneID);
    //     }
   	}
    void Update(){
        
        if(Intersitial.GetComponent<Intersitial>().isClosed()){
            SceneManager.LoadScene(scene);
        }
    }
}
