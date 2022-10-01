using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    bool gameEnd = false;
    public  float restartDelay = 2f;
    public void GameOver()
    {
        if(gameEnd == false)
        {
            Debug.Log("Game Over");
            gameEnd = true;
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
