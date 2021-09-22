/*
 * Created by: Samantha Parton
 * Date Created: 9/22/2021
 * 
 * last Edited by: Samantha Parton
 * Last Updated: 9/22/2021
 * 
 * Description: Controls the ammo
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    /***Variables***/
    public float Damage = 100f;
    public float Lifetime = 2f;


    private void OnEnable()
    {
        CancelInvoke();
        Invoke("Die", Lifetime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Health H = other.gameObject.GetComponent<Health>();
        H.HealthPoints -= Damage;
        Die();
    }

    void Die()
    {
        gameObject.SetActive(false);
    }


}
