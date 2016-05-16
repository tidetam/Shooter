using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEditor;

public class SetAttributes : MonoBehaviour {
	public static int hp=100;      
	public static int coins=0;
	public static int power=20;
	public static int hpRaise = 1;
	public static int powerRaise = 1;
	public static int hpCoins = 100;
	public static int powerCoins = 300;
	public string attribute_type;



	Text text;                      // Reference to the Text component.


	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();

	}


	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		if (attribute_type=="HP")
		text.text = "HP:        "+hp;
		else if (attribute_type=="power")
			text.text = "Damage Per shoot: "+power;
		else if (attribute_type=="coins")
			text.text="Remaining Coins: " + coins;
		else if (attribute_type=="coins_header")
			text.text="Coins: " + coins;
	}
	public void addHPClicked(){
		if (coins >= hpCoins) {
			hp += hpRaise;
			coins -= hpCoins;
		} 
		else {
//			EditorUtility.DisplayDialog ("Error!", "You do not have enough coins!", "ok");
		}
	}
	public void addPowerClicked(){
		if (coins >= powerCoins) {
			power += powerRaise;
			coins -= powerCoins;
		} 
		else {
//			EditorUtility.DisplayDialog ("Error!", "You do not have enough coins!", "ok");
		}
	}
	public static void addCoins(int coinsToAdd){
		coins += coinsToAdd;
	}
}
