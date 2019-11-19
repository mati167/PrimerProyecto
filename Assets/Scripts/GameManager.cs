
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GameHasEnded = false;
    float delay = 1f;
    public GameObject completeLevelUI;
    public float prevScore = 0;

    public void Start()
    {
        prevScore = Score.score;
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        
    }

    public void EndGame()
    {
        if (!GameHasEnded)
        {
            if (!GameConfig.resetScore) 
            { 
                GameHasEnded = true;
                Invoke("Restart", delay);
            }
            else
                Invoke("FinishGame", delay);
        }
    }

    public void Restart()
    {
        Score.score = prevScore;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void FinishGame()
    {
        SceneManager.LoadScene(4);
    }
}
