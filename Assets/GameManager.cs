using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //just want to do for once
    private bool gameHasEnded = false;

    public void EndGame()
    {
        if (gameHasEnded)
            return;
        gameHasEnded = true;
        Debug.Log("END GAME");
    }
}
