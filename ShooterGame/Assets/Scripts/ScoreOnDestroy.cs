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

public class ScoreOnDestroy : MonoBehaviour
{
    public int ScoreValue = 50;

    private void OnDestroy()
    {
        GameManager.Score += ScoreValue;
    }
}
