using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class health : MonoBehaviour
{
    //when you die you die
    public int life = 100;

    public TMP_Text healthText;

    void Start()
    {
        healthText.text = "Life: " + life;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //== compares = changes
        if (collision.gameObject.tag == "killer")
        {
            life -= 10;
            healthText.text = "Life: " + life;
            if (life <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (collision.gameObject.tag == "repair")
        {
            life += 20;
            healthText.text = "Life: " + life;

        }
        if (life > 100)
        {
            life = 100;
            healthText.text = "Life: " + life;
        }
    }
       private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag == "killer")
        {
            life -= 10;
            healthText.text = "Life: " + life;
            if (life <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
