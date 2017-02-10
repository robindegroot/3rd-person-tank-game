using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
    private int health;
    public static EnemyHealth enemyhp;
    void Start()
    {
        enemyhp = this;
        health = 100;
    }


    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void Hurt(int damage)
    {
        health -= damage;

    }
}
