using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	public float explosionPower = 1.0f;
	public float upwardsForce = 1.0f;
	public float explosionRadius = 1.0f;
	
	void Start () {
		foreach(Transform gib in transform){
			Rigidbody rigidbody = gib.gameObject.GetComponent<Rigidbody>();

			rigidbody.AddExplosionForce(explosionPower, transform.position,upwardsForce,explosionRadius,ForceMode.Impulse);
		}
	}
}
