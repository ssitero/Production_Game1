using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{

    public static bool GameIsWon = false;
    public GameObject WinMenuUI;


    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player"){

            if (player.gameObject.SetActive(false)
            
            {
                Win();
            }
        }
    }


    public void Win(){

        WinMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsWon = true;
}


    public void QuitGame()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Main_Menu");

    }

}