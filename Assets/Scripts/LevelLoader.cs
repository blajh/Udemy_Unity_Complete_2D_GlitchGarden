using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private float _splashLoadDelay = 3f;
	private int _currentSceneIndex;

	private void Start () {
		CheckIfSplashScreen();
	}

	private void CheckIfSplashScreen () {
		_currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		if (_currentSceneIndex == 0) {
			StartCoroutine(WaitForTime());
		}
	}

	IEnumerator WaitForTime () {
		yield return new WaitForSeconds(_splashLoadDelay);
		LoadNextScene();
	}

	private void LoadNextScene () {
		SceneManager.LoadScene(_currentSceneIndex + 1);
	}
}
