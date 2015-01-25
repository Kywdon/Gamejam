using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


public class GestionEvent : MonoBehaviour
{
    private EventListScript.EventList currentEvent = new EventListScript.EventList();
    private static string[] warTab, scienceTab, spiritualityTab = new string[3];
    private int warRandom, scienceRandom, spiritualityRandom;
    private bool verifBool;
	private static List<int> warTabRand = new List<int>();
	private static List<int> scienceTabRand = new List<int>();
	private static List<int> spiritualityTabRand = new List<int>();
	private static int countCycle = new int();
	private static int day = 1;
	public static int nbRand;
	public static FactionScript.Faction player = new FactionScript.Faction(true);
	public static FactionScript.Faction bot = new FactionScript.Faction(false);
	private static int[] choices = new int[2];
	private int[] botStat = new int[3];
	
	// Use this for initialization
	void Start () {
		if (this.tag == "Fond") {
			UpdateButton();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void UpdateButton()
    {
		this.audio.Play ();
				countCycle ++;
				if (countCycle == 1) {
						GameObject.Find ("LogBox").GetComponent<Text> ().text = "Leonleon’s Peacock only got 20 cycle to build up their civilization… Neighboring planet, Peafowlia will soon meet, " +
								"crash on Leonleon and then you’ll have to do everything for your peacock survival.  Will you exterminate them ? " +
								"Nor convert them to your faith ? Maybe will you use your head to do something else ? It’s up to you !";
						warTab = new string[3] {"","",""};
						scienceTab = new string[3] {"","",""};
						spiritualityTab = new string[3] {"","",""};
				}
				if (countCycle > 1 && countCycle < 22) {
						DayEvent ();
						nbRand = Random.Range (0, 3);
						player.CountIteration (this, nbRand);
						bot.CountIteration (this, nbRand);
				}
				if (countCycle < 21) {
						verifBool = true;
						do {
								verifBool = false;
								warRandom = Random.Range (0, 20);
								foreach (int wardata in warTabRand) {
										if (wardata == warRandom) {
												verifBool = true;
										}
								}
						} while ( verifBool == true);
						warTabRand.Add (warRandom);

						do {
								verifBool = false;
								scienceRandom = Random.Range (0, 20);
								foreach (int sciencedata in scienceTabRand) {
										if (sciencedata == scienceRandom) {
												verifBool = true;
										}
								}
						} while ( verifBool == true);
						scienceTabRand.Add (scienceRandom);

						do {
								verifBool = false;
								spiritualityRandom = Random.Range (0, 20);
								foreach (int spiritualitydata in spiritualityTabRand) {
										if (spiritualitydata == spiritualityRandom) {
												verifBool = true;
										}
								}
						} while ( verifBool == true);
						spiritualityTabRand.Add (spiritualityRandom);
						
				
						if (this.tag == "WarButton") {
								GameObject.Find ("LogBox").GetComponent<Text> ().text += "\r\n" + warTab [1];
						} else if (this.tag == "ScienceButton") {
								GameObject.Find ("LogBox").GetComponent<Text> ().text += "\r\n" + scienceTab [1];
						} else {
								GameObject.Find ("LogBox").GetComponent<Text> ().text += "\r\n" + spiritualityTab [1];
						}



						warTab = currentEvent.getTabValues (warRandom, "WarButton");
						scienceTab = currentEvent.getTabValues (scienceRandom, "ScienceButton");
						spiritualityTab = currentEvent.getTabValues (spiritualityRandom, "SpiritualityButton");

						GameObject.Find ("TextWarButton").GetComponent<Text> ().text = warTab [0];
						GameObject.Find ("TextScienceButton").GetComponent<Text> ().text = scienceTab [0];
						GameObject.Find ("TextSpiritualityButton").GetComponent<Text> ().text = spiritualityTab [0];
				} else if (countCycle == 21) {
						if (this.tag == "WarButton") {
								GameObject.Find ("LogBox").GetComponent<Text> ().text += "\r\n" + warTab [1];
						} else if (this.tag == "ScienceButton") {
								GameObject.Find ("LogBox").GetComponent<Text> ().text += "\r\n" + scienceTab [1];
						} else {
								GameObject.Find ("LogBox").GetComponent<Text> ().text += "\r\n" + spiritualityTab [1];
						}
						GameObject.Find ("HeadText").GetComponent<Text> ().text = "HOW SHOULD WE REACT TO THOSE STRANGERS ?!";
						GameObject.Find ("TextWarButton").GetComponent<Text> ().text = "ATTACK";
						GameObject.Find ("TextScienceButton").GetComponent<Text> ().text = "Talk";
						GameObject.Find ("TextSpiritualityButton").GetComponent<Text> ().text = "Pacify";
						GameObject.Find ("HeadText").GetComponent<Text> ().text = "HOW DO WE DO THAT ?!";
				} else if (countCycle == 22) {
						if (this.tag == "WarButton") {
								choices [0] = player.War;
								GameObject.Find ("TextWarButton").GetComponent<Text> ().text = "EXTERMINATE";
								GameObject.Find ("TextScienceButton").GetComponent<Text> ().text = "COLONIZE";
								GameObject.Find ("TextSpiritualityButton").GetComponent<Text> ().text = "SEND MISSIONARIES";
						} else if (this.tag == "ScienceButton") {
								choices [0] = player.Science;
								GameObject.Find ("TextWarButton").GetComponent<Text> ().text = "SEND KILLING ROBOTS";
								GameObject.Find ("TextScienceButton").GetComponent<Text> ().text = "Win with a debate";
								GameObject.Find ("TextSpiritualityButton").GetComponent<Text> ().text = "Educate them";
						} else {
								choices [0] = player.Spirituality;
								GameObject.Find ("TextWarButton").GetComponent<Text> ().text = "Preach zealously";
								GameObject.Find ("TextScienceButton").GetComponent<Text> ().text = "Share knowledge";
								GameObject.Find ("TextSpiritualityButton").GetComponent<Text> ().text = "Spread your faith";
						}
				} else if (countCycle == 23) {
						if (this.tag == "WarButton") {
								choices [1] = player.War;
						} else if (this.tag == "ScienceButton") {
								choices [1] = player.Science;
						} else {
								choices [1] = player.Spirituality;
						}
						EndGame ();
				}
		}
	
		private int part_paon;	

		private void DayEvent()
		{
				part_paon = day;
				if (part_paon > 10)
						part_paon -= 10;
				GameObject.Find ("NumeroDay" + day).GetComponent<Text> ().enabled = true;
				if (this.tag == "WarButton") {
			Debug.Log ("Paon_" + part_paon + "// Paon_" + day + "_War");
						GameObject.Find("Paon_" + part_paon).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("Paon_" + day + "_War");
						GameObject.Find ("Day" + day).GetComponent<Image> ().enabled = true;
						GameObject.Find ("Day" + day).GetComponent<Image> ().sprite = Resources.Load<Sprite> ("IcoGuerrier");
				
						day++;     
				}
				if (this.tag == "ScienceButton") {
                    GameObject.Find("Paon_" + part_paon).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Paon_" + day + "_Science");
						GameObject.Find ("Day" + day).GetComponent<Image> ().enabled = true;
						GameObject.Find ("Day" + day).GetComponent<Image> ().sprite = Resources.Load<Sprite> ("IcoScience");
						day++;
				}
				if (this.tag == "SpiritualityButton") {
                    GameObject.Find("Paon_" + part_paon).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Paon_" + day + "_Spirituality");
						GameObject.Find ("Day" + day).GetComponent<Image> ().enabled = true;
						GameObject.Find ("Day" + day).GetComponent<Image> ().sprite = Resources.Load<Sprite> ("IcoSpirite");
						day++;
				}
		}
		
		

		private void EndGame(){
		int  statTrois , statFinalPlayer , statFinalBot;
		if (player.War> player.Science) {
			if (player.Science > player.Spirituality) {
				statTrois = player.Spirituality;
				}
			else {
				statTrois = player.Science;
				}
		}
		else if (player.War > player.Spirituality) {
			statTrois = player.Spirituality;
			
				}
		else {
			statTrois = player.War;
				}
		botStat [0] = bot.War;
		botStat [1] = bot.Science;
		botStat [2] = bot.Spirituality;

		botStat.OrderByDescending (n => n);

		statFinalPlayer = choices[0]+choices[1]*(statTrois/2 + 1);
		statFinalBot = botStat[2]+botStat[1]*(botStat[0]/2 + 1);

		if (statFinalPlayer > statFinalBot) {
			Debug.Log("Victory");
		}
		else {
			Debug.Log("Lose");
		}


		
	}
}    

