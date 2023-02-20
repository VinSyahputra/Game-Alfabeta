using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedback : MonoBehaviour
{
    public GameObject DataSoal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void feedback(){
        DataSoal.GetComponent<DataSoal>().control(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
