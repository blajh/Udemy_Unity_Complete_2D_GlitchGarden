using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private float _splashLoadDelay = 3f;

	private void Awake() {
		StartCoroutine(LoadStartScene());
	}

	IEnumerator LoadStartScene() {
		yield return new WaitForSeconds(_splashLoadDelay);
		SceneManager.LoadScene(1);
	}
}
