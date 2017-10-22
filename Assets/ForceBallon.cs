using UnityEngine;
using System.Collections;

public class ForceBallon : MonoBehaviour {


	public GameObject Force;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col){
		if(col.gameObject.name.Contains("Press")){
			Force.SetActive(true);

		}
	}
}
