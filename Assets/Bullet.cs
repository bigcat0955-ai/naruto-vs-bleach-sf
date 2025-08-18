using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    private Rigidbody2D rb => GetComponent<Rigidbody2D>();

    



    // Update is called once per frame
    void Update() => transform.right = rb.linearVelocity;   


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Target")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);

            UI.Instance.AddScore();
        
        }
    }

    
        
    
}
