using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public void StartGame()
   {
        // see on nupu PLAY jaoks , mis suunab meid esimesele Scene-le 
        SceneManager.LoadScene(1);

   }

    public void QuitGame()
    {
        // see in nuppu quit jaoks mis paneb mängu kinni
        Application.Quit();
    }
 

}
