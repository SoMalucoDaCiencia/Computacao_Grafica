using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FimJogo : MonoBehaviour
{
    public GameObject endGamePanel; 
    public TextMeshProUGUI endGameMessage; 
    public Button restartButton;
    public float gameDuration = 60f;

    private float timer;
    private bool isGameActive = false;

    void Start()
    {
        timer = gameDuration;
        isGameActive = true;

        // Oculta o painel de fim de jogo no in�cio
        endGamePanel.SetActive(false);

        // Adiciona funcionalidade ao bot�o de rein�cio
        restartButton.onClick.AddListener(RestartGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                EndGame(false); // Tempo acabou, jogador perdeu
            }
        }
    }

    public void EndGame(bool hasWon)
    {
        isGameActive = false;
        endGamePanel.SetActive(true);

        if (hasWon)
        {
            endGameMessage.text = "Parab�ns, voc� ganhou!";
        }
        else
        {
            endGameMessage.text = "Que pena, voc� perdeu!";
        }
    }

    public void RestartGame()
    {
        // Reinicia a cena atual
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    public void CheckWinCondition(int remainingBatteries)
    {
        if (remainingBatteries <= 0)
        {
            EndGame(true); // Jogador coletou todas as baterias
        }
    }
}
