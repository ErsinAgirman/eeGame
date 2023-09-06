using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public Rotate rotate;
    public Spawner spawner;

    public Animator anim;

    public void EndGame()
    {   
        if (gameHasEnded)
        return;

        rotate.enabled = false;
        spawner.enabled = false;

        anim.SetTrigger("EndGame");

        gameHasEnded = true;
        Debug.Log("Game Over");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
