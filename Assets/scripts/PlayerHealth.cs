using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
	public GameObject gibs;
	public Animator gameOverAnim;
	public Animator playAgainAnim;

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "enemy"){
			Instantiate (gibs, transform.position,Quaternion.identity);
			DisplayUI ();
			GameManager.playerDead = true;
			Destroy (gameObject);
		}
	}

	void DisplayUI(){
		gameOverAnim.gameObject.SetActive(true);
		playAgainAnim.gameObject.SetActive(true);
		gameOverAnim.SetTrigger("playerDead");
		playAgainAnim.SetTrigger("playerDead");
	}
}
