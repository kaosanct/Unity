﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

	SpriteRenderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<SpriteRenderer> ();
	}

	IEnumerator Fadeout(){

		for (float f = 1f; f >= -0.05f ; f -= 0.05f){
			Color c = rend.material.color;
			c.a = f;
			rend.material.color = c;
			yield return new WaitForSeconds(0.05f);
		}
	}

	public void StartFading(){
		StartCoroutine ("Fadeout");
	}


}
