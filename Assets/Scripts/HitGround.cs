using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HitGround : MonoBehaviour {
public Text endScreen;
public GameObject player;
 public GameObject animals;
public Button buttRef;
public Text butText;


	void OnTriggerEnter2D(Collider2D other)
	{
		//when the player hits the ground, destroy all the animals and clouds, disable player control and display the restart button and final score
		if(other.tag == "Player"){
			player.GetComponent<PlatformerCharacter2D>().enabled = false;
			player.GetComponent<Platformer2DUserControl>().enabled = false;
			
			endScreen.text="Final Score: "+player.GetComponent<EatAnimal>().Score;
			foreach (Transform child in animals.transform) {
				GameObject.Destroy(child.gameObject);
 			}
			buttRef.interactable=true;
			butText.text="Restart Game";
		}
		else {
			Destroy(other.gameObject);

		}
	}
}
