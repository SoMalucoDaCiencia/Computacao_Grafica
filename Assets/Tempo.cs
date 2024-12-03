using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tempo : MonoBehaviour
{
    public float totalTime = 15f; // Tempo total em segundos
    private float remainingTime;
    public Text timerText; // Referência ao texto na UI

    void Start()
    {
        remainingTime = totalTime; // Inicializa o tempo restante
    }

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime; // Reduz o tempo a cada frame
            Debug.Log("Tempo restante: " + remainingTime);
            UpdateTimerUI();
        }
        else
        {
            EndGame(); // Chama o método de fim de jogo
        }
    }

    void UpdateTimerUI()
    {
        if (timerText != null)
        {
            int minutes = Mathf.FloorToInt(remainingTime / 60f);
            int seconds = Mathf.FloorToInt(remainingTime % 60f);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Exibe no formato MM:SS
        }
    }

    void EndGame()
    {
        Debug.Log("Tempo acabou! Fim de jogo.");
        // Aqui você pode implementar o fim do jogo, como recarregar a cena ou mostrar uma mensagem.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
