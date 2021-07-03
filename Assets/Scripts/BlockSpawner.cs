using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {
	public Transform[] spawnPoints;
	[Space] public GameObject blockPrefab;
	public float SpawnStart = 2f;
	public float rateOfSpawn = 1f;
	private float time = 0f;

	void Update () {
		time += Time.deltaTime;
		if (time >= SpawnStart) {
			SpawnBlocks ();
			SpawnStart += rateOfSpawn;
		}
	}

	void SpawnBlocks(){
		int randomIndex = Random.Range (0, spawnPoints.Length);
		for (int i = 0; i < spawnPoints.Length; i++) {
			if (randomIndex != i) {
				Instantiate (blockPrefab, spawnPoints [i].position, Quaternion.identity);
			}
		}
	}
}
