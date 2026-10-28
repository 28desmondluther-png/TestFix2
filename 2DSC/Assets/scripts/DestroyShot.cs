using UnityEngine;

public class DestroyShot : MonoBehaviour
{

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            
            Destroy(gameObject);
        }
    }
}
