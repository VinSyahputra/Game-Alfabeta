using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterAnimate : MonoBehaviour
{
    public void Awake(){
    	transform.LeanMoveLocal(new Vector2(-740,-80), 1).setEaseOutQuart().setLoopPingPong();
    }
}
