using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
public class BackToHome : MonoBehaviour
{
    float x,y;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.localScale.x;
        y = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        transform.localScale = new Vector2(x * 1.2f, y*1.2f);
    }

    void OnMouseUp(){
        transform.localScale = new Vector2(x,y);
        SceneManager.LoadScene(10);
    }
}