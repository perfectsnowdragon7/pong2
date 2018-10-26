using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour {

    public float speed;

    Rigidbody rb;
    float horz;
    float vert;
    
	// Use this for initialization
	void Start () {
        horz = Random.Range(-1, 1);
        vert = Random.Range(-1, 1);
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //float horz = Input.GetAxis("Horizontal");
        //float vert = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horz * Time.deltaTime, vert * Time.deltaTime);
        
        transform.Translate(direction * speed);
	}

    private void OnCollisionEnter(Collision collision)
    {
        print("hit");
        horz *= -1;
        vert *= -1;
    }
}
