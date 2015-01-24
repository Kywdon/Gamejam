using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgresBar : MonoBehaviour
{


    #region Attributes
    public GameObject statBarJoueur;
    private static int warIterration , scienceIterration , spiritualityIterration ;

    #endregion

    #region Unity Methods
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    #endregion

    #region Other Methods
    public void SetStats(float value) 
    {

        
        statBarJoueur.GetComponent<Scrollbar>().size +=value;
        int nbRand = Random.Range(0, 3);


        
        if (nbRand == 0)
        {
            GameObject scrollBar = GameObject.Find("BotWarBarProgress");
            scrollBar.GetComponent<Scrollbar>().size += value;
        }
        else if (nbRand == 1)
        {
            GameObject scrollBar = GameObject.Find("BotScienceBarProgress");
            scrollBar.GetComponent<Scrollbar>().size += value;

        }
        else 
        {
            GameObject scrollBar = GameObject.Find("BotSpiritualityBarProgress");
            scrollBar.GetComponent<Scrollbar>().size += value;
        }

    }

    private void TextBarValueChange()
    {
        if (this.tag == "WarButton")
        {
            GameObject text = GameObject.Find("PlayerWarBarProgressText");
            text.GetComponent<Text>().text = warIterration + "/ 21";
            Debug.LogError("test");
        }
        if (this.tag == "ScienceButton")
        {
            GameObject text = GameObject.Find("PlayerScienceBarProgressText");
            text.GetComponent<Text>().text = scienceIterration + "/ 21";

        }
        if (this.tag == "SpiritualityButton")
        {
            GameObject text = GameObject.Find("PlayerSpiritualityBarProgressText");
            text.GetComponent<Text>().text = spiritualityIterration + "/ 21";

        }
    }
    public void CountIteration() 
    {
        if (this.tag == "WarButton" && warIterration < 21)
        {
            warIterration += 1;
            TextBarValueChange();
            
        }
        else if (this.tag == "ScienceButton" && scienceIterration < 21)
        {
            scienceIterration += 1;
            TextBarValueChange();
        }
        else if (this.tag == "SpiritualityButton" && spiritualityIterration < 21)
        {
            spiritualityIterration += 1;
            TextBarValueChange();
        }
        SkillCheck();
    }

    private void SkillCheck()
    {

        if (scienceIterration == 10)
        {
            Debug.LogError("Reussi");
        }
    
    }
    #endregion



    }