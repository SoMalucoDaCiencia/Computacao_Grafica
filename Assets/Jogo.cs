using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogo : MonoBehaviour
{
    public int totalBatteries = 3; // N�mero total de baterias
    private int collectedBatteries = 0; // N�mero de baterias coletadas

    // M�todo chamado quando o jogador coleta uma bateria
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

    // M�todo para terminar o jogo
    void EndGame()
    {
        Debug.Log("Voc� coletou todas as baterias! Fim de jogo!");
        // Aqui voc� pode reiniciar a cena ou exibir uma tela de vit�ria.
        // Para reiniciar a cena atual:
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
