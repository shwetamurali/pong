using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour {

	public void startAnim()
    {
        this.GetComponent<Animator>().Play("ballAnim", -1, 0.0f);
    }
	
}
