using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static bool playerDead = false;

	void Start(){
		playerDead = false;
	}

	void Update () {
		if(playerDead){
			if(Input.anyKeyDown){
				Application.LoadLevel ("main_game");
			}
		}
	
	}
}
