using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{
    [SerializeField]
    private Transform muzzle;
    private AudioSource source;
    public Projectile projectile;
    private float bulletSpeed;
    private float firerate;
    private float nextFireTime;
	
	void Start ()
    {
        source = GetComponent<AudioSource>();
        bulletSpeed = 20f;
        nextFireTime = 0;
        firerate = 5f;
	}
	
	
	void Update ()
    {
        if (Input.GetMouseButton(0)&&Time.time>=nextFireTime)
        {
            Shooting();
            source.Play();
        }
	}
    private void Shooting()
    {
        Projectile newpProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile;
        newpProjectile.SetSpeed(bulletSpeed);
        nextFireTime = Time.time + firerate;
    }
    
}
