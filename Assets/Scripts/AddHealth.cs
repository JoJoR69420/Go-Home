using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour
{
   public int HealthAdd;
   public PlayerHP Playerhealth;


    //audio
    [SerializeField]
    private AudioSource addHPSFX;

    public void Adding()
    {
        
        Playerhealth.health += 1;
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        addHPSFX.Play();

        if (other.gameObject.tag == "Player")
        {
            Adding();
        }


    }
}