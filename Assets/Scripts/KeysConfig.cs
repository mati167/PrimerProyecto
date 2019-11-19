
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeysConfig : MonoBehaviour
{
    static public string leftKey = "a";
    static public string rightKey = "d";
    public string tempLeft;
    public string tempRight;
    public Text text;

    public void ChangeLeft()
    {
       // tempLeft = Input.
    }
    public void ChangeRight()
    {

    }

    public void Save()
    {

    }

    public void Options()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

}
