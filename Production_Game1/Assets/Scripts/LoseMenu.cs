using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{

    public static bool GameIsLost = false;
    public GameObject LoseMenuUI;


    // Update is called once per frame
    void Update()
    {
        if (GameIsLost == true)
        {
            Lose();
        }

    }


    public void Lose()
    {

        LoseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsLost = true;
    }


    public void QuitGame()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Main_Menu");

    }

}