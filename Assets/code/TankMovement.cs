using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour
{
    private Vector3 movement;
    private Rigidbody rigidBody;
    private float x;
    private float z;
    private AudioSource source;
    [SerializeField]
    private AudioClip drive;
    public float speed;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
         
    }
    void Update()
    {
        Vector3 velocity = movement * speed * Time.fixedDeltaTime;
        rigidBody.MovePosition(rigidBody.position + velocity);
        x = Input.GetAxisRaw("Horizontal");
         z = Input.GetAxisRaw("Vertical");
        movement = transform.forward.normalized;
        if (Input.GetAxisRaw("Vertical") == 0)
        {
            source.clip = drive;
            source.Play();
            source.loop = true;
        }
        Debug.Log(z);     
    }

    void FixedUpdate()
    {

        rigidBody.rotation = Quaternion.Euler(rigidBody.rotation.eulerAngles + new Vector3(0f, x, 0f));

    }
}

    