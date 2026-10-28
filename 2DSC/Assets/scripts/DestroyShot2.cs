using UnityEngine;

public class DestroyShot2 : MonoBehaviour
{
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag != "killer")
        {
            Destroy(gameObject);
        }
    }
}
