using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToAllMenu : MonoBehaviour
{
    

    public void toExit()
    {
        Application.Quit();
    }

    public void GoToScene(string scenename)
    {
       
        SceneManager.LoadScene(scenename);
    }
     
       
}

