using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomWall : MonoBehaviour {

	void OnCollisionEnter (Collision hit) {
		if (hit.gameObject.CompareTag ("Ball")) {
			// 現在のシーンを再読込
			int scene = SceneManager.GetActiveScene().buildIndex;
			SceneManager.LoadScene (scene);
		}
	}
}
