using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //just want to do for once
    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public void EndGame()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("End Game");

        gameHasEnded = true;
        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}