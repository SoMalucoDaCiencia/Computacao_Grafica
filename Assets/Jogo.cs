using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogo : MonoBehaviour
{
    public int totalBatteries = 3; // Número total de baterias
    private int collectedBatteries = 0; // Número de baterias coletadas

    // Método chamado quando o jogador coleta uma bateria
    public void CollectBattery()
    {
        collectedBatteries++;

        Debug.Log("Bateria coletada! Baterias restantes: " + (totalBatteries - collectedBatteries));

        // Verifica se todas as baterias foram coletadas
        if (collectedBatteries >= totalBatteries)
        {
            EndGame();
        }
    }

    // Método para terminar o jogo
    void EndGame()
    {
        Debug.Log("Você coletou todas as baterias! Fim de jogo!");
        // Aqui você pode reiniciar a cena ou exibir uma tela de vitória.
        // Para reiniciar a cena atual:
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
