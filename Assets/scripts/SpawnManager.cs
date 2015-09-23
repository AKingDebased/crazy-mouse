using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	public Transform[] spawnPoints;
	public float spawnTimer = 1.0f;
	public GameObject gameObject;
	public Vector3 spawnOffset;

	private float timeSinceSpawn = 0;

	void Update(){
		timeSinceSpawn += Time.deltaTime;

		if(timeSinceSpawn >= spawnTimer){
			Spawn ();
		}
	}

	void Spawn(){
		int randomIndex = Random.Range (0,spawnPoints.Length);

		Instantiate (gameObject,spawnPoints[randomIndex].position + spawnOffset,Quaternion.identity);
		timeSinceSpawn = 0;
	}
}
