using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("number", 0);
        PlayerPrefs.SetInt("getSkor", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
