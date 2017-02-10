using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    private bool dead;
    private AudioSource source;
    private int health;
    public static PlayerHealth playerhp;
    [SerializeField]
    private AudioClip hit;
    [SerializeField]
    private AudioClip boom;
	void Start ()
    {
        source = GetComponent<AudioSource>();
        playerhp = this;
        health = 100;
        dead = false;
	}
	

	void Update ()
    {
	    if(health <= 0 && !dead )
        {
            dead = true;
           
            StartCoroutine(Death());
            
        }
	}
    IEnumerator Death()
    {
        source.PlayOneShot(boom);
        source.loop = false;
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
    public void Hurt(int damage)
    {
        source.PlayOneShot(hit);
        source.loop = false;
        health -= damage;
    }
}
