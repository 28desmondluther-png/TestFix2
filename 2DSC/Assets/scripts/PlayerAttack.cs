using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;
public class PlayerAttack : MonoBehaviour
{
    public float shotspeed;
    public GameObject bullet;
    public int ammo = 50;
    //shooting
    public TMP_Text gunText;

    void Start()
    {
        gunText.text = "Ammo: " + ammo;
    }
    public void OnAttack()
    {
        //only shoot if you have ammo and game is unpaused
        if (ammo > 0 && Time.timeScale == 1)
        {
            GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity);
            Destroy(shot, 5);
            Vector3 mousePos = Mouse.current.position.ReadValue();
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            Vector3 shootDir = mousePos - transform.position;
            shootDir.Normalize();
            shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir * shotspeed;
            ammo -= 1;
            gunText.text = "Ammo: " + ammo;
        }


    }
}
//KILL!!
