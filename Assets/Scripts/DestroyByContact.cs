﻿using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary"))
            return;

        Instantiate(explosion, transform.position, transform.rotation);

        if (other.CompareTag("Player"))
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
