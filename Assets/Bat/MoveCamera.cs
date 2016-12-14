using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {

		var speed = 3.0;
		if (Input.GetKey("q")) {
	   transform.Translate(Vector3.left*Time.deltaTime*6f);
        }else if (Input.GetKey("e"))
        {
		transform.Translate(Vector3.right*Time.deltaTime*6f);      
		}
    }
}
