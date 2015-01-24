using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgresBar : MonoBehaviour
{


    #region Public Attributes
    public GameObject statBarJoueur;
    #endregion

    #region Private Attributes
    private float taille = 0.04761905f;

    private int nbRand;
    private static FactionScript.Faction player = new FactionScript.Faction(true);
    private static FactionScript.Faction bot = new FactionScript.Faction(false);
    #endregion

    #region Unity Methods
    // Use this for initialization
    void Start()
    {



        GameObject.Find("PlayerWarBarProgress").GetComponent<Scrollbar>().size = taille ;
        GameObject.Find("PlayerScienceBarProgress").GetComponent<Scrollbar>().size = taille ;
        GameObject.Find("PlayerSpiritualityBarProgress").GetComponent<Scrollbar>().size = taille ;

        GameObject.Find("BotWarBarProgress").GetComponent<Scrollbar>().size = taille;
        GameObject.Find("BotScienceBarProgress").GetComponent<Scrollbar>().size = taille ;
        GameObject.Find("BotSpiritualityBarProgress").GetComponent<Scrollbar>().size = taille ;
        Debug.Log(player.War + " / " + player.Science + " / " + player.Spirituality);
        
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
    public void SetStats() 
    {
        nbRand = Random.Range(0, 3);
        player.CountIteration(this, nbRand);
        bot.CountIteration(this, nbRand);

        
        GameObject.Find("PlayerWarBarProgress").GetComponent<Scrollbar>().size = taille * player.War;
        GameObject.Find("PlayerScienceBarProgress").GetComponent<Scrollbar>().size = taille * player.Science;
        GameObject.Find("PlayerSpiritualityBarProgress").GetComponent<Scrollbar>().size = taille * player.Spirituality;

        GameObject.Find("BotWarBarProgress").GetComponent<Scrollbar>().size = taille * bot.War;
        GameObject.Find("BotScienceBarProgress").GetComponent<Scrollbar>().size = taille * bot.Science;
        GameObject.Find("BotSpiritualityBarProgress").GetComponent<Scrollbar>().size = taille * bot.Spirituality;
        Debug.Log (player.War +" / " +player.Science + " / " +player.Spirituality);
        TextBarValueChange();

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
            text.GetComponent<Text>().text = player.War + "/ 21";
        }
        if (this.tag == "ScienceButton")
        {
            GameObject text = GameObject.Find("PlayerScienceBarProgressText");
            text.GetComponent<Text>().text = player.Science + "/ 21";

        }
        if (this.tag == "SpiritualityButton")
        {
            GameObject text = GameObject.Find("PlayerSpiritualityBarProgressText");
            text.GetComponent<Text>().text = player.Spirituality + "/ 21";

        }

        if (nbRand == 0)
        {
            GameObject text = GameObject.Find("BotWarBarProgressText");
            text.GetComponent<Text>().text = bot.War + "/ 21";
        }
        else if (nbRand == 1)
        {
            GameObject scrollBar = GameObject.Find("BotScienceBarProgressText");
            scrollBar.GetComponent<Text>().text = bot.Science + "/ 21";

        }
        else
        {
            GameObject scrollBar = GameObject.Find("BotSpiritualityBarProgressText");
            scrollBar.GetComponent<Text>().text = bot.Spirituality + "/ 21";
        }
    }


    /// <summary>
    /// Changed the value bar for the bot 
    /// </summary>
    /// <param name="_nbRand">Number randomize for bot attribute </param>
    private void BotTextBarValueChange(int _nbRand )
    {

    }
    /// <summary>
    /// This are the number of iteration for each bot attribute
    /// </summary>
    /// <param name="_nbRand">Number Randomizer for bot attribute</param>
    


    #endregion



}