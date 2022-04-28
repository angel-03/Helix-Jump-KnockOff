using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }

    public void gameOver()
    {
        Time.timeScale = 0;
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    

    public void quit()
    {
        Debug.Log("Quit!!!");
        Application.Quit();
    }
}
