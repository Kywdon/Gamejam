using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgresBar : MonoBehaviour
{


    #region Attributes
    public GameObject statBar;
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

        statBar.GetComponent<Scrollbar>().size +=value;
    }
    #endregion


}
