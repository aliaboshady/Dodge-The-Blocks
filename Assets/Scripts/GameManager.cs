using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public float slowMotionRate = 10f;

	public void EndGame () {
		StartCoroutine (RestartLevel ());
	}

	IEnumerator RestartLevel(){
		Time.timeScale = 1f / slowMotionRate;
		Time.fixedDeltaTime = Time.fixedDeltaTime / slowMotionRate;
		yield return new WaitForSeconds (1f / slowMotionRate);
		Time.timeScale = 1f;
		Time.fixedDeltaTime = Time.fixedDeltaTime * slowMotionRate;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}