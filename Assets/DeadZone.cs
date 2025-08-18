using UnityEngine;

public class DeadZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Target" || collision.tag == "Player")
        {
            Time.timeScale = 0; // Pause the game
            Debug.Log("Game Over");

        }
    }
}
