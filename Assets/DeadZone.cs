using UnityEngine;

public class DeadZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Target" || collision.tag == "Player")
        {
            UI.Instance.OpenEndScreen();

        }
    }
}
