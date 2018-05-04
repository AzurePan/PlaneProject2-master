using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    [SerializeField]
    private Text scoreText;
    private Director director;

	// Use this for initialization
	void Start () {
        director = Director.Instance;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = director.Score.ToString();
		
	}
}
