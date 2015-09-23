using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float speed = 1.0f;
	public float rotateSpeed = 1.0f;
	public float jumpPower = 1.0f;
	public float forwardMomentum = 1.0f;

	private bool isGrounded;
	private Rigidbody rigidbody;
	private Animator anim;

	void Start(){
		rigidbody = GetComponent<Rigidbody>();
		anim = transform.GetChild (0).GetComponent<Animator>();
	}

	void Update () {
		if(Input.GetKey("w")){
			transform.position += transform.forward * speed * Time.deltaTime;
		}

		if(Input.GetKey("s")){
			transform.position += -(transform.forward * speed * Time.deltaTime);
		}

		if(Input.GetKey("a")){
			transform.Rotate (-Vector3.up * rotateSpeed * Time.deltaTime);
		}

		if(Input.GetKey("d")){
			transform.Rotate (Vector3.up * rotateSpeed * Time.deltaTime);
		}
	}

	void FixedUpdate(){
		if(isGrounded){
			if(Input.GetKeyDown("space")){
				rigidbody.AddForce(transform.up * jumpPower, ForceMode.Impulse);
				rigidbody.AddForce (transform.forward * forwardMomentum,ForceMode.Impulse);
			}
		}
	}

	void OnCollisionStay(Collision collision){
		if(collision.gameObject.tag == "ground"){
			isGrounded = true;
			anim.SetBool("isJumping",false);
		}
	}

	void OnCollisionExit(Collision collision){
		isGrounded = false;
		anim.SetBool ("isJumping",true);
	}
}
