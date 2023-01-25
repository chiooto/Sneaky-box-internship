using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{

    public void Load()
    {
        SceneManager.LoadScene("Main");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }


    
}
