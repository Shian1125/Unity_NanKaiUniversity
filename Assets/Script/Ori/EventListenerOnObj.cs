using UnityEngine;
using System.Collections;

public class EventListenerOnObj : MonoBehaviour
{
	public Cube _cube;
	void Awake()
	{
		EventListener.Get(gameObject).onClick = OnClick;
		EventListener.Get(gameObject).onDown = OnDown;
		EventListener.Get(gameObject).onEnter = OnEnter;
		EventListener.Get(gameObject).onExit = OnExit;
		EventListener.Get(gameObject).onUp = OnUp;
		_cube = GameObject.Find("Cube").GetComponent<Cube>();
	}
	
	
	private void OnClick(GameObject button)
	{
		Debug.Log(button.name + " click");
	}
	
	
	private void OnDown(GameObject button)
	{
		Debug.Log(button.name + " down");
		if(button.name == "Forward")
			_cube.forward = true;
		if(button.name == "Back")
			_cube.back = true;
		if(button.name == "Left")
			_cube.left = true;
		if(button.name == "Right")
			_cube.right = true;
	}
	
	
	private void OnEnter(GameObject button)
	{
		Debug.Log(button.name + " enter");
	}
	
	
	private void OnExit(GameObject button)
	{
		Debug.Log(button.name + " exit");
	}
	
	
	private void OnUp(GameObject button)
	{
		Debug.Log(button.name + " up");
		if(button.name == "Forward")
			_cube.forward = false;
		if(button.name == "Back")
			_cube.back = false;
		if(button.name == "Left")
			_cube.left = false;
		if(button.name == "Right")
			_cube.right = false;
	}
}