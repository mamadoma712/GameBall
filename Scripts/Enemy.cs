using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRb;
    public float enemySpeed = 3.0f;
    private GameObject player;
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized; // normalized предотвращает увеличение силы
        enemyRb.AddForce(lookDirection * enemySpeed);                                        // врага в зависимости от расстояния

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
