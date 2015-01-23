using UnityEngine;
using System.Collections;

public class ProgressionBarre : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public Texture2D barreVie;
	public int lifeLeft = 100; //Vie qui peut descendre avec le temps.
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(10,20,barreVie.width * lifeLeft / 100, barreVie.height), barreVie);
	}
}
