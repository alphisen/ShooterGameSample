/*
 * Created by: Samantha Parton
 * Date Created: 9/20/2021
 * 
 * last Edited by: Samantha Parton
 * Last Updated: 9/20/2021
 * 
 * Description: Deal damage to any colliding object with health component
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyDamage : MonoBehaviour
{

    /***Variables***/
    public float DamageRate = 10f; //damage per second

    private void OnTriggerStay(Collider other)
    {
        Health H = other.gameObject.GetComponent<Health>();

        if(H == null) { return; }

        H.HealthPoints -= DamageRate * Time.deltaTime;
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
