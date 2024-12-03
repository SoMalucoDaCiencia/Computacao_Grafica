using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float speed = 5f;
    public float mouseSensitivity = 500f;
    public bool isGameActive = false;

    private float rotationY = 0f;

    void Update()
    {
        if (isGameActive)
        {
            MovePlayer();
            RotatePlayerWithMouse();
        }

    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }

    void RotatePlayerWithMouse()
    {
        // Rotação do jogador com o movimento do mouse
        //float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X");

        // Atualiza a rotação no eixo Y (horizontal)
        rotationY += mouseX * mouseSensitivity * Time.deltaTime;

        // Aplica a rotação no transform
        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);
    }

    public void StartGame()
    {
        isGameActive = true;
    }
}
