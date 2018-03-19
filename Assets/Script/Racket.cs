﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour {

	/// <summary>
	/// 加える力の大きさ
	/// </summary>
	public float accel = 1000.0f;

	/// <summary>
	/// 入力方向
	/// </summary>
	private Vector3 inputVector;

	private Rigidbody rig;

	// Use this for initialization
	void Start () {
		rig = this.GetComponent<Rigidbody> ();
		inputVector = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		// 入力を拾う
		inputVector = transform.right * Input.GetAxisRaw("Horizontal") * accel;
	}

	void FixedUpdate() {
		// 力を加える
		rig.AddForce(inputVector, ForceMode.Impulse);
	}
}
