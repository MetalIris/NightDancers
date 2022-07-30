using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    private GameObject menuObj;
    [SerializeField]
    private GameObject optionsObj;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit(); 
    }

    public void Options()
    {
        menuObj.SetActive(false);
        optionsObj.SetActive(true);
    }

    public void ToMenu()
    {
        menuObj.SetActive(true);
        optionsObj.SetActive(false);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
