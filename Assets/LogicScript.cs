using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject finishScreen;
    public GameObject menuScreen;
    public int cherryCount = 0;
    
    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void startGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void finish()
    {

       finishScreen.SetActive(true );
    }

    public void quit() {
        Application.Quit();
    }

    public void menu() {
        menuScreen.SetActive(true);
    }

    public void back() {
        menuScreen.SetActive(false);
    }

   


}
