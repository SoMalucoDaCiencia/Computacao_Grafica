using UnityEngine;

public class Menu : MonoBehaviour
{
    public Tempo tempo;
    public GameObject jogo;
    public Jogador jogador;
    public void PlayGame()
    {
        Debug.Log("Iniciando o jogo...");
        tempo.isGameActive = true;
        tempo.gameObject.SetActive(true);
        //jogo.SetActive(true);
        jogador.isGameActive = true;
        jogador.StartGame();
        gameObject.SetActive(false);
    }
    void Start()
    {
    }
    void Update()
    {
        
    }
}
