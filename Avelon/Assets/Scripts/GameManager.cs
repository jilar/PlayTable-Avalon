using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public Image board;
	public Sprite[] boardSprites = new Sprite[6];

	public Dropdown PlayerO; //dropdown to select player
	public Toggle LL;       //program lady of lake last
	public Toggle Percival;
	public Toggle Morgana;
	public Toggle Mordred;
	public Toggle Oberon;

	//array indicating which roles are added into game
	//order of array: Lady of the Lake, Percival, Morgana, Mordred, Oberon
	private bool[] additions= new bool[5]{false,false,false,false,false};
	private int players;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		setOptions();
	}

	public void setOptions(){
		if (LL.isOn){
			additions[0]=true;
		}
		if (Percival.isOn){
			additions[0]=true;
		}
		if (Morgana.isOn){
			additions[0]=true;
		}
		if (Oberon.isOn){
			additions[0]=true;
		}

		if(PlayerO.value==0){
			players=5;
		}else if(PlayerO.value==1){
			players=6;
		}else if(PlayerO.value==2){
			players=7;
		}else if(PlayerO.value==3){
			players=8;
		}else if(PlayerO.value==4){
			players=9;
		}else if(PlayerO.value==5){
			players=10;
		}

		Debug.Log (players);
			
	}
	 
	public void setboard(){
		board.sprite = boardSprites[PlayerO.value];
	}
	//public void createDeck ();
	//public void dealDeck();

}
