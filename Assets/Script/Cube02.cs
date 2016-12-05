using UnityEngine;
using System.Collections;

public class Cube02 : MonoBehaviour {

	public float mSpeed;

	// Use this for initialization
	void Start () {
		Debug.Log("hello!");
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log("Update~~~~~");

		if(Input.GetKey(KeyCode.A)){
			Debug.Log("get A");
			gameObject.transform.Translate(Vector3.forward * mSpeed * Time.deltaTime);
		}

	}
}
