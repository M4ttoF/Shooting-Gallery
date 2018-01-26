using UnityEngine;
using System.Collections;

public class projectileShooter : MonoBehaviour {
	public GameObject bullet;
	public GameObject bulletHole;
	public float delayTime=8;
	public AudioSource sound;

	private float counter=0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetMouseButtonDown(0) && counter>delayTime){
			Instantiate(bullet,transform.position,transform.rotation);
			sound.Play();

			RaycastHit hit;
			Ray ray = new Ray(transform.position,transform.forward);
			if(Physics.Raycast(ray, out hit, 100f)){
				Instantiate(bulletHole,hit.point,Quaternion.FromToRotation(Vector3.up, hit.normal));
			}
		}
		counter += Time.deltaTime;


	}
}