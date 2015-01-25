using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FactionScript : MonoBehaviour {

    public class Faction
    {
    private int war, science, spirituality;
    private bool _isPlayer;


    


	// Use this for initialization
	public Faction (bool isPlayer) {
	    war = 1;
        science = 1;
        spirituality = 1;
        _isPlayer = isPlayer;
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    


    #region Accessor

    public int War  
    {
        get
        {
            return war;
        }
    }

    public int Science  
    {
        get
        {
            return science;
        }
    }

    public int Spirituality  
    {
        get
        {
            return spirituality;
        }
    }

    #endregion

    /// <summary>
    /// This method count and changes the value for text bar for the player
    /// </summary>
    public void CountIteration(GestionEvent other , int _nbRand)
    {

        if (_isPlayer == true)
        {
            if (other.tag == "WarButton" && war < 21)
            {
                war += 1;
                
            }
            else if (other.tag == "ScienceButton" && science < 21)
            {
                science += 1;
            }
            else if (other.tag == "SpiritualityButton" && spirituality < 21)
            {
                spirituality += 1;
            }
        }
        else
        {
            if (_nbRand == 0)
            {
                war += 1;
            }
            else if (_nbRand == 1)
            {
                science += 1;
            }
            else
            {
                spirituality += 1;
            }
        }

    }

    private void SkillCheck()
    {

        if (science == 10)
        {

        }

    }


}
}