
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    private bool gameIsOver = false;
    public void EndGame()
    {
        if(gameIsOver == false)
        {
            gameIsOver = true;
            Debug.Log("GAME OVER");
            Restart();
        }




    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void ActualEnd()
    {
        SceneManager.LoadScene(2);
    }
}
