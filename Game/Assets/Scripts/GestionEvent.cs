using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GestionEvent : MonoBehaviour {
    private EventListScript.EventList currentEvent = new EventListScript.EventList();
    private string[] warTab, scienceTab, spiritualityTab;
    private int warRandom, scienceRandom, spiritualityRandom;
    private bool verifBool;
    private int i;
    private int[] warTabRand ,scienceTabRand, spiritualityTabRand;
    /*private List<int> warTabRand = new List<int>();
    private List<int> scienceTabRand = new List<int>();
    private List<int> spiritualityTabRand = new List<int>();*/
	// Use this for initialization
	void Start () {
        Debug.Log("Je suis dans le Start");
        warTabRand = new int[21];
        scienceTabRand = new int[21];
        spiritualityTabRand = new int[21];
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void UpdateButton()
    {

        Debug.Log("Je suis dans Update");
        Debug.Log(spiritualityTabRand[0]);
        
         {
              i= 0;
             verifBool = false;
             warRandom = Random.Range(1, 21);
             Debug.Log("Je suis dans le do");

             while (verifBool == true) ;
             foreach (int wardata in warTabRand)
             {
                 Debug.Log("Je suis dans le Foreach");
                     if (verifBool =! true)
                     {
                         Debug.Log("Je suis dans le If verifBool");
                         i++;
                         if (wardata == warRandom)
                         {
                             Debug.Log("Je suis dans If wardata");
                             verifBool = true;
                         } 
                     }
                           


                 }
           
         } 

            warTabRand[i] = warRandom;



        /*
         do
         {
             i = 0;
             verifBool = false;
             scienceRandom = Random.Range(1, 21);
             foreach (int sciencedata in scienceTabRand)
             {
                 if (verifBool = !true)
                 {
                     i++;
                     if (sciencedata == scienceRandom)
                     {
                         verifBool = true;
                     }
                 }
             }
         } while (verifBool == false);
         scienceTabRand[i] = scienceRandom;




        
         do
         {
             i = 0;
             verifBool = false;
             spiritualityRandom = Random.Range(1, 21);
             foreach (int spiritualitydata in spiritualityTabRand)
             {
                 if (verifBool = !true)
                 {
                     i++;
                     if (spiritualitydata == spiritualityRandom)
                     {
                         verifBool = true;
                     }
                 }
             }
         } while (verifBool == false);
         spiritualityTabRand[i] = spiritualityRandom;
        
         */
        //Debug.Log(warRandom + " / " + scienceRandom + " / " + spiritualityRandom);


        warTab = currentEvent.getTabValues(warRandom, "WarButton");
        scienceTab = currentEvent.getTabValues(scienceRandom, "ScienceButton");
        spiritualityTab = currentEvent.getTabValues(spiritualityRandom, "SpiritualityButton");

        GameObject.Find("TextWarButton").GetComponent<Text>().text = warTab[0] ;
        GameObject.Find("TextScienceButton").GetComponent<Text>().text = scienceTab[0];
        GameObject.Find("TextSpiritualityButton").GetComponent<Text>().text = spiritualityTab[0];

    }
}
