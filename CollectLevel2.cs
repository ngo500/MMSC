using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectLevel2 : MonoBehaviour
{
    public GameObject health1;                            //variable for the first health item that needs to be collected
    public GameObject health2;                            //variable for the second health item that needs to be collected
    public GameObject ammo1;                              //variable for the first ammo item that needs to be collected
    public GameObject ammo2;                              //variable for the second ammo item that needs to be collected

    public void Update()                                  //function that continuously checks if all 4 items have been collected
    {
        if(!health1 && !health2 && !ammo1 && !ammo2)      //if these 4 items no longer exist, they have been picked up by the player
        {                                                 //all 4 items have been picked up, so the level is won
          SceneManager.UnloadSceneAsync("GameLevel2");    //unload the current level
          SceneManager.LoadScene("WinLevel2");            //and load the transitional level win screen for level 2 
        }
        else                                               //else, 1 or more items still exists, and the level continues
        {}                                                 //do nothing
    }
}
