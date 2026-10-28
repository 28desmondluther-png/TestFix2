using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Life = 100;

    void Start()
    {
       
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //== compares = changes
        if (collision.gameObject.tag == "EnmHazard")
        {
            Life -= 10;
            if (Life <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    
}
