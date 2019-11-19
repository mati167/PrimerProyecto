using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Transform end;
    public Text scoreText;
    public float offset = 8;
    static public float score;
    public float prevLevelScore = 0;

    private void Start()
    {
       prevLevelScore = score;
       Debug.Log(prevLevelScore); 
    }
    void Update()
    {
        if (score < end.position.z + prevLevelScore)
        {
            score = player.position.z + offset + prevLevelScore;
            scoreText.text = score.ToString("0");
        }
        
    }

    private void OnDestroy()
    {
        Debug.Log(score);
    }
}
