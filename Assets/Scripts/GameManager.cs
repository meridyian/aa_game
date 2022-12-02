using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Canvas EndCanvas;
    //just want to do for once
    private bool gameHasEnded = false;
    public Button QuitButton;
    public Button RestartButton;
    public Text totalScore;
    public Text current;
   

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public void OnEnable()
    {
        
        EndCanvas.gameObject.SetActive(false);
        RestartButton.onClick.AddListener(RestartLevel);
        QuitButton.onClick.AddListener(Application.Quit);
    }
    public void EndGame()
    {
        if (gameHasEnded)
            return;

        current.gameObject.SetActive(false);
        totalScore.text = "Total Score: " + Score.PinCount.ToString();

        rotator.enabled = false;
        spawner.enabled = false;

        
        animator.SetTrigger("End Game");

        EndCanvas.gameObject.SetActive(true);

        gameHasEnded = true;
        
    }

    public void RestartLevel()
    {
        Debug.Log("restart",transform);
        SceneManager.LoadScene("First Level");
    }
}
