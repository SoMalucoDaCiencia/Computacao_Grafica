using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tempo : MonoBehaviour
{
    public float totalTime = 60f; 
    private float remainingTime;
    public Text timerText; 
    public bool isGameActive = false;

    void Start()
    {
        remainingTime = totalTime; 
    }

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime; 
            UpdateTimerUI();
        }
        else
        {
            EndGame(); 
        }
    }

    void UpdateTimerUI()
    {
        if (timerText != null)
        {
            int minutes = Mathf.FloorToInt(remainingTime / 60f);
            int seconds = Mathf.FloorToInt(remainingTime % 60f);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); 
        }
    }

    void EndGame()
    {
        Debug.Log("Tempo acabou! Fim de jogo.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
