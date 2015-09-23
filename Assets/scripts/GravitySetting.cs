using UnityEngine;
using System.Collections;

public class GravitySetting : MonoBehaviour {
	public float gravityStrength = 1.0f;

	void Start () {
		Physics.gravity = new Vector3(0,-gravityStrength,0);
	}
}
