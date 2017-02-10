using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
    private GameObject player;
    [serializefield]
    private NavMeshAgent nav;
    

	void Start ()
    {
        
        nav = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");

	}

    public void Chase()
    {
        nav.Resume();
        nav.destination = player.transform.position;
    }

    public void Attack()
    {
        nav.Stop();
        EnemyShoot.enemyShoot.Shoot();
    }

    public void Idle()
    {
        nav.Stop();
    }
}
