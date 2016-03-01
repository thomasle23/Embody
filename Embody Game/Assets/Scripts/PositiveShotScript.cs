using UnityEngine;
using System.Collections;

/// <summary>
/// Projectile behavior
/// </summary>
public class PositiveShotScript : MonoBehaviour
{
    // 1 - Designer variables
    HUDScript hud;
    /// <summary>
    /// Damage inflicted
    /// </summary>
    public int damage = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "EnemyShot")
        {
            hud = GameObject.Find("Main Camera").GetComponent<HUDScript>();
            hud.IncreaseScore(5);
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// Projectile damage player or enemies?
    /// </summary>
    public bool isEnemyShot = false;


    void Start()
    {
        // 2 - Limited time to live to avoid any leak
        Destroy(gameObject, 1); // 1sec
    }
}
