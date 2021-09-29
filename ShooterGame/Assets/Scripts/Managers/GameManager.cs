/*
 * Created by: Samantha Parton
 * Date Created: 9/29/2021
 * 
 * last Edited by: Samantha Parton
 * Last Updated: 9/29/2021
 * 
 * Description: game manager to control golbal game behaviors
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    /*** VARIABLES ***/

    #region GameManager Singleton

    static GameManager gm;
    public static GameManager GM { get { return gm;  } }

    #endregion

    void CheckGameManagerIsInScene()
    {
        if (gm == null)
        {
            gm = this;
        }
        else 
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
