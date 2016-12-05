using UnityEngine;
using System.Collections;

public class UnityChanRun : MonoBehaviour {

	public float rSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(Vector3.up * rSpeed * Time.deltaTime);
	}
}
