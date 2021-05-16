using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AmmoUIDisplay : MonoBehaviour
{

    public int currentAmmo = 0;                     //variable that holds the current amount of ammo the players has
    [SerializeField] Text ammoText;                 //variable for the text for displaying the ammo to the UI
    [SerializeField] private PlayerAmmo ammo;       //variable the references the player's ammo

    void Start()                                    //on start, get the current ammo from the player, and display it
    {
        currentAmmo = ammo.GetPlayerAmmo();         //store the current amount of ammo
        string temp = "" + currentAmmo;             //turn this number into a string
        ammoText.text = temp;                       //display the number to the UI
    }

    public void Update()                            //checks continuously, and will update if the player has used any ammo
    {
      if (Input.GetButtonDown("Fire1")){            //if the player pressed the left mouse click
        currentAmmo = ammo.GetPlayerAmmo();         //store the current amount of ammo
        string temp = "" + currentAmmo;             //turn this number into a string
        ammoText.text = temp;                       //display the number to the UI
      }//if
      else{}//else                                  //else, no ammo was used, and no need to update
    }

    public void Change()                            //can be called to change the ammo UI to a certain number,
    {                                               //such as when an ammo item is picked up
      currentAmmo = ammo.GetPlayerAmmo();           //store the current amount of ammo
      string temp = "" + currentAmmo;               //turn this number into a string
      ammoText.text = temp;                         ////display the number to the UI
    }
}
