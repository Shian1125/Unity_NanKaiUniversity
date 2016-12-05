using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

	public float _moveSpeed;
	//public float _RotaSpeed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//前進
		if(Input.GetKey(KeyCode.W)){
			gameObject.transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
			//Debug.Log("move forward");
		}
		//後退
		if(Input.GetKey(KeyCode.S)){
			gameObject.transform.Translate(Vector3.back * _moveSpeed * Time.deltaTime);
			//Debug.Log("move back");
		}

		//左
		if(Input.GetKey(KeyCode.A)){
			gameObject.transform.Translate(Vector3.left * _moveSpeed * Time.deltaTime);
			Debug.Log("turn left");
		}

		//右
		if(Input.GetKey(KeyCode.D)){
			gameObject.transform.Translate(Vector3.right * _moveSpeed * Time.deltaTime);
			Debug.Log("turn right");
		}

		//Move();
	}
	public bool forward;
	public bool back;
	public bool left;
	public bool right;
	public void Move(){
		if(forward && !back){
			gameObject.transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
		}
		if(back && !forward){
			gameObject.transform.Translate(Vector3.back * _moveSpeed * Time.deltaTime);
		}
		if(right && !left){
			gameObject.transform.Translate(Vector3.right * _moveSpeed * Time.deltaTime);
		}
		if(left && !right){
			gameObject.transform.Translate(Vector3.left * _moveSpeed * Time.deltaTime);
		}
	}
}
