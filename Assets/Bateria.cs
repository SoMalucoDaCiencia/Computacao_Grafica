using UnityEngine;

public class Bateria : MonoBehaviour
{

    // Este m�todo � chamado automaticamente quando um Collider entra em contato com a bateria
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica se o objeto que colidiu � o jogador
        {
            // Chama o m�todo de coleta de bateria no GameManager
            Jogo jogo = FindFirstObjectByType<Jogo>();
            if (jogo != null)
            {
                jogo.CollectBattery();  // A bateria foi coletada
            }

            // Destroi a bateria depois de ser coletada
            Destroy(gameObject);  // Remove a bateria da cena

            Debug.Log("Bateria coletada!");
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
