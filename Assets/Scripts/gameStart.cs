using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameStart : MonoBehaviour {
	public Text Titles;
	// Use this for initialization
	IEnumerator Start () {
		 
        yield return new WaitForSeconds(1.5f);
       Titles.text=" ";
	}
	
	
}
