using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public Text text;

    public void Start()
    {
        text.text = Score.score.ToString("0");
        Score.score = 0;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
