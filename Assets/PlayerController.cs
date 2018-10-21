using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// ←矢印が押されたとき
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.Translate(-3, 0, 0); //←に3動かす
		}

		// →矢印が押されたとき
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.Translate(3, 0, 0); //→に3動かす
		}
		
	}
}
