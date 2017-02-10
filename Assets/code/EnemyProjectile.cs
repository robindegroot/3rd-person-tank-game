using UnityEngine;
using System.Collections;

public class EnemyProjectile : MonoBehaviour
{
    private float speed;


    void Start()
    {
        Destroy(gameObject, 15f);
    }


    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void SetSpeed(float value)
    {
        speed = value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("PlayerParts"))
        {
            PlayerHealth.playerhp.Hurt(50);
            Destroy(gameObject);
        }
        if(other.CompareTag("Props"))
        {
            Destroy(gameObject);
        }
    }
}
