using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject finishScreen;
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

   


}
