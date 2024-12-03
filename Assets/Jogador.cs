using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float speed = 5f;
    public bool isGameActive = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (isGameActive)
        {
            MovePlayer();
        }

    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }

    public void StartGame()
    {
        isGameActive = true;
    }
}
