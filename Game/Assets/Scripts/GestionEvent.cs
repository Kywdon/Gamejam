using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GestionEvent : MonoBehaviour
{
    private EventListScript.EventList currentEvent = new EventListScript.EventList();
    private string[] warTab, scienceTab, spiritualityTab = new string[3];
    private int warRandom, scienceRandom, spiritualityRandom;
    private bool verifBool;
    private int i;
	private static List<int> warTabRand = new List<int>();
	private static List<int> scienceTabRand = new List<int>();
	private static List<int> spiritualityTabRand = new List<int>();
	private static int countCycle = new int();

	// Use this for initialization
	void Start () {

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

			GameObject.Find ("TextWarButton").GetComponent<Text> ().text = warTab [0];
			GameObject.Find ("TextScienceButton").GetComponent<Text> ().text = scienceTab [0];
			GameObject.Find ("TextSpiritualityButton").GetComponent<Text> ().text = spiritualityTab [0];

			warTab = currentEvent.getTabValues (warRandom, "WarButton");
			scienceTab = currentEvent.getTabValues (scienceRandom, "ScienceButton");
			spiritualityTab = currentEvent.getTabValues (spiritualityRandom, "SpiritualityButton");



			if (this.tag == "WarButton"){
				GameObject.Find ("LogBox").GetComponent<Text>().text += "\r\n" + warTab[1];
			}
			else if (this.tag == "ScienceButton"){
				GameObject.Find ("LogBox").GetComponent<Text>().text += "\r\n" + scienceTab[1];
			}
			else {
				GameObject.Find ("LogBox").GetComponent<Text>().text += "\r\n" + spiritualityTab[1];
			}
		}
    }

	public void gameInitialize(){
		warTabRand.Add (0);
		scienceTabRand.Add (0);
		spiritualityTabRand.Add (0);
		warRandom = Random.Range (1, 21);
		warTabRand.Add (warRandom);
		scienceRandom = Random.Range (1, 21);
		scienceTabRand.Add (scienceRandom);
		spiritualityRandom = Random.Range (1, 21);
		spiritualityTabRand.Add (spiritualityRandom);
		GameObject.Find ("LogBox").GetComponent<Text> ().text = "Leonleon’s Peacock only got 20 cycle to build up their civilization… Neighboring planet, Peafowlia will soon meet, crash on Leonleon and then you’ll have to do everything for your peacock survival.  Will you exterminate them ? Nor convert them to your faith ? Maybe will you use your head to do something else ? It’s up to you !";
		warTab = currentEvent.getTabValues (warRandom, "WarButton");
		scienceTab = currentEvent.getTabValues (scienceRandom, "ScienceButton");
		spiritualityTab = currentEvent.getTabValues (spiritualityRandom, "SpiritualityButton");
		GameObject.Find ("TextWarButton").GetComponent<Text> ().text = warTab [0];
		GameObject.Find ("TextScienceButton").GetComponent<Text> ().text = scienceTab [0];
		GameObject.Find ("TextSpiritualityButton").GetComponent<Text> ().text = spiritualityTab [0];
		warTab = currentEvent.getTabValues (warRandom, "WarButton");
		scienceTab = currentEvent.getTabValues (scienceRandom, "ScienceButton");
		spiritualityTab = currentEvent.getTabValues (spiritualityRandom, "SpiritualityButton");
	}
}
