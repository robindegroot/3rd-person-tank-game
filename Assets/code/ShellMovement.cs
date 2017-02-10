using UnityEngine;
using System.Collections;

public class ShellMovement : MonoBehaviour
{
    public float speed;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.right* speed;
    }
}
