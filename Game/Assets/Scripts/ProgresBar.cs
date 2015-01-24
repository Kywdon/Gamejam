using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgresBar : MonoBehaviour
{


    #region Public Attributes
    public GameObject statBarJoueur;
    #endregion

    #region Private Attributes
    private static int warIterration, scienceIteration, spiritualityIteration, botWarIteration, botScienceIteration, botSpiritualityIteration;
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

    #region Other Public Methods

    /// <summary>
    /// This method change the value for the scrollbar and  create randomized number for the bot
    /// </summary>
    /// <param name="value"></param>
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
        BotCountIteration(nbRand);
        BotTextBarValueChange(nbRand);
    }

    /// <summary>
    /// This method count and changes the value for text bar for the player
    /// </summary>
    public void CountIteration()
    {
        if (this.tag == "WarButton" && warIterration < 21)
        {
            warIterration += 1;
            TextBarValueChange();

        }
        else if (this.tag == "ScienceButton" && scienceIteration < 21)
        {
            scienceIteration += 1;
            TextBarValueChange();
        }
        else if (this.tag == "SpiritualityButton" && spiritualityIteration < 21)
        {
            spiritualityIteration += 1;
            TextBarValueChange();
        }
        SkillCheck();
    }
    #endregion

    #region Others Private Method

    /// <summary>
    /// Changed the value bar for the player 
    /// </summary>
    private void TextBarValueChange()
    {
        if (this.tag == "WarButton")
        {
            GameObject text = GameObject.Find("PlayerWarBarProgressText");
            text.GetComponent<Text>().text = warIterration + "/ 21";
        }
        if (this.tag == "ScienceButton")
        {
            GameObject text = GameObject.Find("PlayerScienceBarProgressText");
            text.GetComponent<Text>().text = scienceIteration + "/ 21";

        }
        if (this.tag == "SpiritualityButton")
        {
            GameObject text = GameObject.Find("PlayerSpiritualityBarProgressText");
            text.GetComponent<Text>().text = spiritualityIteration + "/ 21";

        }
    }
    /// <summary>
    /// Changed the value bar for the bot 
    /// </summary>
    /// <param name="_nbRand">Number randomize for bot attribute </param>
    private void BotTextBarValueChange(int _nbRand )
    {
        if (_nbRand == 0)
        {
            GameObject text = GameObject.Find("BotWarBarProgressText");
            text.GetComponent<Text>().text = botWarIteration + "/ 21";
        }
        else if (_nbRand == 1)
        {
            GameObject scrollBar = GameObject.Find("BotScienceBarProgressText");
            scrollBar.GetComponent<Text>().text = botScienceIteration + "/ 21";

        }
        else
        {
            GameObject scrollBar = GameObject.Find("BotSpiritualityBarProgressText");
            scrollBar.GetComponent<Text>().text = botSpiritualityIteration + "/ 21";
        }
    }
    /// <summary>
    /// This are the number of iteration for each bot attribute
    /// </summary>
    /// <param name="_nbRand">Number Randomizer for bot attribute</param>
    private void BotCountIteration(int _nbRand)
    {
        if (_nbRand == 0)
        {
            botWarIteration += 1;
        }
        else if (_nbRand == 1)
        {
            botScienceIteration += 1;
        }
        else
        {
            botSpiritualityIteration += 1;
        }
    }

    private void SkillCheck()
    {

        if (scienceIteration == 10)
        {

        }

    }
    #endregion



}