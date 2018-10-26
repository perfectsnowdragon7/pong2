using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Rigidbody))]
public class Paddle : MonoBehaviour {

    public enum Player { Player1, Player2, AI};
    public Player playerType;
    public float speed;

    Ball ball;
    AudioSource source;
    Rigidbody rb;
    float vert;

	// Use this for initialization
	void Start () {
        ball = FindObjectOfType<Ball>();
        source = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        switch (playerType)
        {
            case Player.Player1:
                vert = Input.GetAxis("Vertical") * speed * Time.deltaTime;
                rb.AddForce(new Vector3(0, vert, 0), ForceMode.VelocityChange);
                break;
            case Player.Player2:
                vert = Input.GetAxis("Vertical2") * speed * Time.deltaTime;
                rb.AddForce(new Vector3(0, vert, 0), ForceMode.VelocityChange);
                break;
            case Player.AI:
                if (ball.transform.position.y > transform.position.y)
                {
                    vert = 1 * speed * Time.deltaTime;
                    print("go up");
                }
                if (ball.transform.position.y < transform.position.y)
                {
                    vert = -1 * speed * Time.deltaTime;
                    print("go down");
                }
                rb.AddForce(new Vector3(0, vert, 0), ForceMode.VelocityChange);
                break;
            default:
                break;
        }
    }
}
