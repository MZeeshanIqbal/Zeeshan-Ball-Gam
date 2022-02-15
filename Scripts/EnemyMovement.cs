using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody enemyRb;
    public float downForce = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        enemyRb.AddForce(Vector3.down * downForce ,ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
