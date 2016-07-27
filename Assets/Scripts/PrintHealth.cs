using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PrintHealth : MonoBehaviour {

	public GameObject player;

	Text textObj;

	// Use this for initialization
	void Start () {
		textObj = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		int health;
		if(player == null){
			health = 0;
		} else {
			health = player.GetComponent<Killable>().currentHealth;
		}

		textObj.text = "Health: " + health.ToString ();

	}
}
