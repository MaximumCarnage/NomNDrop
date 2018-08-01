using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateAnimals : MonoBehaviour {


	public GameObject m_monkeyPrefab;
	public GameObject m_CloudPrefab1;
	public GameObject m_CloudPrefab2;
	public GameObject m_rabbitPrefab;
	public GameObject m_hippoPrefab;
	public GameObject m_parrotPrefab;
	






	// Use this for initialization
	void Start () {
		CreateLevel();
	}
	
	void CreateLevel(){
		//spawn all animals and clouds

		for(int i=0;i<25;i++){
		SpawnAnimal(new Vector2(Random.Range(-8f,5f),Random.Range(-15f,-80f)),m_monkeyPrefab);
		}
		//Spawn Clouds 1
		for(int i=0;i<20;i++){
		SpawnAnimal(new Vector2(Random.Range(-13f,8f),Random.Range(-15f,-110f)),m_CloudPrefab1);
		}
		//Spawn Clouds 2
		for(int i=0;i<20;i++){
		SpawnAnimal(new Vector2(Random.Range(-13f,8f),Random.Range(-15f,-110f)),m_CloudPrefab2);
		}
		//spawn Parrots
		for(int i=0;i<10;i++){
		SpawnAnimal(new Vector2(Random.Range(-13f,8f),Random.Range(-15f,-80f)),m_parrotPrefab);
		}
		//Spawn Hippos
		for(int i=0;i<10;i++){
		SpawnAnimal(new Vector2(Random.Range(-13f,8f),Random.Range(-30f,-100f)),m_hippoPrefab);
		}
		//Spawn rabbits
		for(int i=0;i<5;i++){
		SpawnAnimal(new Vector2(Random.Range(-13f,8f),Random.Range(-15f,-50f)),m_rabbitPrefab);
		}
		

	}

	public void SpawnAnimal(Vector2 spawnPos,GameObject animalPrefab){
		GameObject tmpTile = null; 
		tmpTile = InstanceBlock(spawnPos,animalPrefab);
		tmpTile.transform.parent = gameObject.transform;
		tmpTile.name = ""+animalPrefab.name;
	}
	

	private GameObject InstanceBlock(Vector3 pos,GameObject animalPrefab){
		GameObject tmpanimal = Instantiate(animalPrefab, pos, Quaternion.identity);
        return tmpanimal;
	}

}
