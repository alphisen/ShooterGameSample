/*
 * Created by: Samantha Parton
 * Date Created: 9/20/2021
 * 
 * last Edited by: Samantha Parton
 * Last Updated: 9/20/2021
 * 
 * Description: GameObject health
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    /***Variables***/

    public bool DestroyOnDeath = true;
    public GameObject DeathParticlesPrefab = null;
    [SerializeField] private float _HealthPoints = 100f;

    public float HealthPoints { 
        get { return _HealthPoints; } 
        set { _HealthPoints = value;
            if (HealthPoints <= 0)
            {
                SendMessage("Die", SendMessageOptions.DontRequireReceiver);

                if (DeathParticlesPrefab != null)
                {
                    Instantiate(DeathParticlesPrefab, transform.position, transform.rotation);
                }

                if (DestroyOnDeath)
                {
                    Destroy(gameObject);
                }

            } //end if health = 0

        } //end setter

    } //end public float HealthPoints



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      //  if (Input.GetKeyDown(KeyCode.Space))
       // {
       //     HealthPoints = 0;
       // }

    }
}
