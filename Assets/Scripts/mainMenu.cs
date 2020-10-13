using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    #region Variable Names
    //all the buttons
    public Button btnStart;
    public Button btnOptions;
    public Button btnExit;
    public Button btnReturn;
    public Button btnDesktop;
    public Button btnNo;

    //all the panels 
    public GameObject startMenu;
    public GameObject optionsMenu;
    public GameObject exitMenu;
    #endregion

    #region Start Panel
    // Start is called before the first frame update
    void Start()
    {
        startMenu.SetActive(true);
        optionsMenu.SetActive(false);
        exitMenu.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
        SceneManager.UnloadSceneAsync("mainMenu");
    }
    #endregion

    #region Options Panel
    
    public void Options()
    {
        startMenu.SetActive(false);
        optionsMenu.SetActive(true);
        btnStart.enabled = false;
        btnOptions.enabled = false;
        btnExit.enabled = false;
        btnReturn.enabled = true;
    }

    public void Return()
    {
        startMenu.SetActive(true);
        optionsMenu.SetActive(false);
        btnStart.enabled = true;
        btnOptions.enabled = true;
        btnExit.enabled = true;
        btnReturn.enabled = false;
    }
    #endregion

    #region Exit Panel

    public void Exit()
    {
        startMenu.SetActive(false);
        exitMenu.SetActive(true);
        btnDesktop.enabled = true;
        btnNo.enabled = true;
    }

    public void Desktop()
    {
        Application.Quit();
    }

    public void No()
    {
        startMenu.SetActive(true);
        exitMenu.SetActive(false);
        btnStart.enabled = true;
        btnOptions.enabled = true;
        btnExit.enabled = true;
        btnReturn.enabled = false;
    }
    #endregion
}
