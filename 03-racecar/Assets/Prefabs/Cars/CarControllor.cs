using UnityEngine;
using System.Collections;

public class CarControllor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
			this.transform.Translate(Vector3.forward*Time.deltaTime*30);
		}
	
	}
}
