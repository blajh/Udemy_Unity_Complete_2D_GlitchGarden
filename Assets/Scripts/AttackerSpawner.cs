using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
	[SerializeField] private float _minSpawnDelay = 1f;
	[SerializeField] private float _maxSpawnDelay = 5f;
	[SerializeField] private Attacker _attackerPrefab;

	private bool _isSpawnning = true;
    
    private IEnumerator Start()
    {
		while (_isSpawnning) {
			yield return new WaitForSeconds(UnityEngine.Random.Range(_minSpawnDelay, _maxSpawnDelay));
			SpawnAttacker();
		}
    }

	private void SpawnAttacker() {
		Instantiate(_attackerPrefab, transform.position, Quaternion.identity);
	}
}
