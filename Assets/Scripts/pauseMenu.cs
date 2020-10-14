using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    //panel variables 
    public GameObject gmbOptions;
    public GameObject gmbExit;
    public GameObject gmbPauseMenu;

    public bool onMainMenu;

    // Start is called before the first frame update
    void Start()
    {
        gmbPauseMenu.SetActive(false);
        gmbOptions.SetActive(false);
        gmbExit.SetActive(false);
        onMainMenu = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !onMainMenu)
        {
            gmbPauseMenu.SetActive(true);
            StartCoroutine(pauseDelay());
            Debug.Log("Clicked");
        }
        
        if(onMainMenu && Input.GetKeyDown(KeyCode.Escape))
        {
            gmbPauseMenu.SetActive(false);
            gmbOptions.SetActive(false);
            gmbExit.SetActive(false);
            StartCoroutine(pauseDelay2());
            Time.timeScale = 1;

        }
    }

    IEnumerator pauseDelay()
    {
        yield return new WaitForSeconds(0.2f);
        onMainMenu = true;
    }

    IEnumerator pauseDelay2()
    {
        yield return new WaitForSeconds(0.2f);
        onMainMenu = false;
    }

    public void Inventory()
    {
        gmbPauseMenu.SetActive(true);
        gmbExit.SetActive(false);
        gmbOptions.SetActive(false);
    }

    public void Close()
    {
        gmbExit.SetActive(true);
        gmbPauseMenu.SetActive(true);
        gmbOptions.SetActive(false);
    }

    public void Options()
    {
        gmbPauseMenu.SetActive(true);
        gmbOptions.SetActive(true);
        gmbExit.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenu");
        SceneManager.UnloadSceneAsync("SampleScene");
    }

    public void QuittingofGame()
    {
        Application.Quit();
    }
}
