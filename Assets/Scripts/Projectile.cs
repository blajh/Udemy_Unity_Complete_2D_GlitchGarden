using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f, 10f)]
	[SerializeField]
    private float _projectileSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * _projectileSpeed);
    }
}
