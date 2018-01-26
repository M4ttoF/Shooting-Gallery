using UnityEngine;
using System.Collections;

public class playerComponent : MonoBehaviour {
	public float movespeed;
	// Use this for initialization
	void Start () {
		movespeed = 5f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (movespeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, movespeed * Input.GetAxis ("Vertical") * Time.deltaTime);
	}
}
