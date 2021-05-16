using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpHealth : MonoBehaviour
{

  [SerializeField] private PlayerHealth health;                               //variable for player's health
  [SerializeField] private HealthbarBehaviour ui;                             //variable for healthbar UI
  public int regen = 25;                                                      //default health regen value is 25

  private void OnTriggerEnter2D(Collider2D collider)                          //if a health item is touched, this function is called
  {
    if(collider.gameObject.tag == "Player")                                   //check if collison is player
    {                                                                         //it was, so do the following:
      health.SetPlayerHealth(regen);                                          //call setPlayerHealth to add the regen value
      UnityEngine.Object.Destroy(gameObject);                                 //destroy the health item
      ui.SetHealth(health.GetPlayerHealth(), health.GetPlayerMaxHealth());    //update the UI to reflect the new health value
      Debug.Log("Health is" + health.GetPlayerHealth());                      //console note for debugging purposes
    }//if
    else                                                                      //else, the collison was an enemy
    {                                                                         //no action needed
      Debug.Log("Enemy touched health");                                      //console note for debugging purposes
    }//else 
  }
}
