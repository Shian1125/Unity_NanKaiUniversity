using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public AudioSource _audioSource;
	public AudioClip audio_get;
	public float rSpeed;

	// Use this for initialization
	void Start () {
		_audioSource = Camera.main.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		SelfRota();
	}
	void OnTriggerEnter(Collider other) {
		Destroy(gameObject);
		Score score = GameObject.Find("Score").GetComponent<Score>();
		score.AddPoint();
		score.AddCoin();
		_audioSource.PlayOneShot(audio_get);
		Debug.Log("EAT Coin");
	}
	void SelfRota(){
		this.transform.Rotate(new Vector3(0, 0, 1) * rSpeed * Time.deltaTime);
	}
}
