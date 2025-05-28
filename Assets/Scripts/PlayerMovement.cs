using UnityEngine;

public class PlayerMovementBasic : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;

        // Detectar teclas W, A, S, D diretamente
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector3.forward;  // Frente
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector3.back;     // Trás
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector3.left;     // Esquerda
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector3.right;    // Direita
        }

        // Normalizar para evitar andar mais rápido na diagonal
        moveDirection = moveDirection.normalized;

        // Mover o personagem
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
