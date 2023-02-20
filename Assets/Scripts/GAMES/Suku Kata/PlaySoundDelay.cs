using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundDelay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().PlayDelayed(1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
