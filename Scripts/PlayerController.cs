using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject fireCube;
    public float speed = 10.0f;
    public float Hor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Hor = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * Hor*speed );
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(fireCube, transform.position,fireCube.transform.rotation);
        }
    }
        
}
