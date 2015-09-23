using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	private GameObject player;
	private NavMeshAgent agent;

	void Start () {
		player = GameObject.Find ("playerBody");
		agent = GetComponent<NavMeshAgent>();
	}

	void Update(){
		agent.SetDestination(player.transform.position);
	}
}
