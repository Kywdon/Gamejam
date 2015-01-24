using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GestionEvent : MonoBehaviour
{
    private EventListScript.EventList currentEvent = new EventListScript.EventList();
    private string[] warTab, scienceTab, spiritualityTab;
    private int warRandom, scienceRandom, spiritualityRandom;
    private bool verifBool;
    private int i;
	private static List<int> warTabRand = new List<int>();
	private static List<int> scienceTabRand = new List<int>();
	private static List<int> spiritualityTabRand = new List<int>();
	private static int countCycle = new int();

	// Use this for initialization
	void Start () {
		warTabRand.Add (0);
		scienceTabRand.Add (0);
		spiritualityTabRand.Add (0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void UpdateButton()
    {
		countCycle ++;
		if (countCycle < 21) {
			verifBool = true;

			do {
					verifBool = false;
					warRandom = Random.Range (1, 21);
					foreach (int wardata in warTabRand) {
							if (wardata == warRandom) {
									verifBool = true;
							}
					}
			} while ( verifBool == true);
			warTabRand.Add (warRandom);

			do {
					verifBool = false;
					scienceRandom = Random.Range (1, 21);
					foreach (int sciencedata in scienceTabRand) {
							if (sciencedata == scienceRandom) {
									verifBool = true;
							}
					}
			} while ( verifBool == true);
			scienceTabRand.Add (scienceRandom);

			do {
					verifBool = false;
					spiritualityRandom = Random.Range (1, 21);
					foreach (int spiritualitydata in spiritualityTabRand) {
							if (spiritualitydata == spiritualityRandom) {
									verifBool = true;
							}
					}
			} while ( verifBool == true);
			spiritualityTabRand.Add (spiritualityRandom);
			warTab = currentEvent.getTabValues (warRandom, "WarButton");
			scienceTab = currentEvent.getTabValues (scienceRandom, "ScienceButton");
			spiritualityTab = currentEvent.getTabValues (spiritualityRandom, "SpiritualityButton");

			GameObject.Find ("TextWarButton").GetComponent<Text> ().text = warTab [0];
			GameObject.Find ("TextScienceButton").GetComponent<Text> ().text = scienceTab [0];
			GameObject.Find ("TextSpiritualityButton").GetComponent<Text> ().text = spiritualityTab [0];
		}

    }
}
