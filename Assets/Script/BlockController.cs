using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockController : MonoBehaviour {
	/// <summary>
	/// The scroll label.
	/// </summary>
	public Text scrollLabel;
	/// <summary>
	/// The winner label.
	/// </summary>
	public GameObject winnerLabel;

	/// <summary>
	/// The block prefab.
	/// </summary>
	public Transform blockPrefab;
	/// <summary>
	/// The top wall.
	/// </summary>
	public Transform topWall;

	private const int COLUMNS = 4;
	private const int ROWS = 2;

	// Use this for initialization
	void Start () {
		// 開始場所
		Vector3 pos = new Vector3 (
			              topWall.position.x - topWall.localScale.x / 2 + blockPrefab.localScale.x / 2,
			              0,
			              topWall.position.z - topWall.localScale.z / 2 - blockPrefab.localScale.z / 2);

		for (int row = 0; row <= ROWS; row++) {
			pos.x = topWall.position.x - topWall.localScale.x / 2 + blockPrefab.localScale.x / 2;
			pos.z -= blockPrefab.transform.localScale.z;

			for (int col = 0; col <= COLUMNS; col++) {
				Instantiate (blockPrefab, pos, Quaternion.identity);
				pos.x += blockPrefab.transform.localScale.x;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		// ブロックのカウント
		int count = GameObject.FindGameObjectsWithTag("Block").Length;
		scrollLabel.text = count.ToString ();

		if (count == 0) {
			winnerLabel.SetActive (true);
		}
	}
}
