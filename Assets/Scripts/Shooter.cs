using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
	[SerializeField] private GameObject _projectile;
	[SerializeField] private GameObject _spawnPoint;

	public void Fire() {
		Instantiate(_projectile, _spawnPoint.transform.position, Quaternion.identity);
	}
}
