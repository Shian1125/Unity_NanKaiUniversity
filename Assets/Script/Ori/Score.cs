using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int curScore;
	public Text uiScore;
	public int addScore;
	public GameObject _coin;
	public GameObject _plane;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AddPoint(){
		curScore += addScore;
		uiScore.text = "Score: " + curScore.ToString();
	}
	public void AddCoin(){
		float x = Random.Range(-3.7f, 3.7f);
		float z = Random.Range(-4.0f, 4.0f);
		GameObject newCoin = Instantiate(_coin) as GameObject;
		newCoin.transform.SetParent(_plane.transform);
		newCoin.transform.localPosition = new Vector3(x, 0.16f, z);
		newCoin.transform.localScale = _coin.transform.localScale;
	}
}
