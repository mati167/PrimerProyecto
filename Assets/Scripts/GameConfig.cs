using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameConfig : MonoBehaviour
{
    bool flag = true;
    static public bool resetScore = true;

    public void ChangeToggle()
    {
        if (flag)
            flag = false;
        else
            flag = true;
    }
    public void Save()
    {
        resetScore = flag;
    }
    public void Options()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
