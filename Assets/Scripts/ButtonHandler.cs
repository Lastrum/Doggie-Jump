using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void ToPlay()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
    }
}
