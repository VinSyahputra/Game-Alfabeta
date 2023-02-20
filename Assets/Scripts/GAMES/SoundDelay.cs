using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDelay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().PlayDelayed(2.7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
