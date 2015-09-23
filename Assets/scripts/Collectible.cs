using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collectible : MonoBehaviour {
	public int pointValue = 1;
	
	private Renderer renderer;
    private AudioSource audioSource;
	private Collider collider;

	void Start(){
		audioSource = gameObject.GetComponent<AudioSource>();
		renderer = gameObject.GetComponent<Renderer>();
		collider = gameObject.GetComponent<Collider>();
	}
	
	void OnTriggerEnter(Collider colliderInfo){
		if(colliderInfo.gameObject.tag == "Player"){
			ScoreManager.SetScore(pointValue);
			StartCoroutine(DelayDestroy ());
		}
	}

	IEnumerator DelayDestroy(){
		audioSource.Play ();
		renderer.enabled = false;
		collider.enabled = false;
		yield return new WaitForSeconds(1);
		Destroy (gameObject);
	}
}
