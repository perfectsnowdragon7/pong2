using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]
public class Goal : MonoBehaviour {

    public int score = 0;
    public Text goalUI;
    AudioSource source;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        source = GetComponent<AudioSource>();
        goalUI.text = score.ToString();
	}

    private void OnTriggerEnter(Collider other)
    {
        source.Play();
        score++;
    }
}
