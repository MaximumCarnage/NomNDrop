using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EatAnimal : MonoBehaviour {

	public GameObject player; 
	 public Text endScreen;
	 public Text scoreRef;
	 public Text lifeRef;

	 public Text butText;
	 public Button buttRef;
	 public float life=3;
	 public float Score=0;

	public void Start(){
		 life=3;
		 lifeRef.text="life: 3";
		 scoreRef.text="Score: "+Score;
		 
	}
	void OnTriggerEnter2D(Collider2D other)
	{	//upon colliding with an object bigger than the player that isnt ground, 
	    //destroy player and display rest button as well as the you have died message
		if(other.transform.localScale.x>gameObject.transform.localScale.x&& other.tag!="Ground"){
			life--;
			lifeRef.text="life: "+life;
				if(life==0){
					
					player.GetComponent<Platformer2DUserControl>().enabled=false;
					player.GetComponent<PlatformerCharacter2D>().enabled=false;
					endScreen.text="You have died!";
					Destroy(player);
					buttRef.interactable=true;
					butText.text="Restart Game";

				}
		}
		else{//handle all the different types of animals and thier individual score values
			if(other.tag == "Monkey") {
					Destroy(other.gameObject);
					gameObject.transform.localScale+= new Vector3(Mathf.Abs(0.1f),Mathf.Abs(0.1f),0);
					AddScore(10);
					if(gameObject.transform.localScale.x==1.3){
						Camera.main.orthographicSize++;
				}
				
			}
			else if(other.tag == "Rabbit") {
				Destroy(other.gameObject);
				gameObject.transform.localScale+= new Vector3(Mathf.Abs(0.1f),Mathf.Abs(0.1f),0);
				AddScore(200);
				
			}
			else if(other.tag == "Parrot") {
				Destroy(other.gameObject);
				gameObject.transform.localScale+= new Vector3(Mathf.Abs(0.1f),Mathf.Abs(0.1f),0);
				AddScore(50);
				
			}
			else if(other.tag == "Hippo") {
				Destroy(other.gameObject);
				gameObject.transform.localScale+= new Vector3(Mathf.Abs(0.1f),Mathf.Abs(0.1f),0);
				AddScore(100);
				
			}
		}
	}
	public void AddScore(float Scorevalue){
		Score+=Scorevalue;
		scoreRef.text="Score: "+Score;
	}

}
