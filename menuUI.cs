using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuUI : MonoBehaviour
{
    
    public void ShowMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(3);
    }
    public void SnowCreator()
    {
        SceneManager.LoadScene(1);
    }
    public void ShowSetting()
    {
        SceneManager.LoadScene(2);
    }
}
