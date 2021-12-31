using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 Direction { get; set; }
    public float Range { get; set; }
    public int Damage { get; set; }

    Vector3 spawnPosition;

    private void Start()
    {
        spawnPosition = transform.position;
        GetComponent<Rigidbody>().AddForce(Direction * 50f);
    }

    private void Update()
    {
        if (Vector3.Distance(spawnPosition, transform.position) >= Range) {
            Extinguish();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy") {
            collision.transform.GetComponent<IEnemy>().TakeDamage(5);
        }
        Extinguish();
    }

    void Extinguish() {
        Destroy(gameObject);
    }
}
