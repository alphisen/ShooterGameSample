/*
 * Created by: Samantha Parton
 * Date Created: 9/20/2021
 * 
 * last Edited by: Samantha Parton
 * Last Updated: 9/20/2021
 * 
 * Description: Continuously moves gane object
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    /***Variables***/

    public float MaxSpeed = 10f;


    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * MaxSpeed * Time.deltaTime;
    } // end update
}
