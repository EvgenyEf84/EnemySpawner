using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerSpawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private float _delay;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] public Transform _target;

    private void Start()
    {
        _spawnPoints = new List<Transform>(_spawnPoints);
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        var wait = new WaitForSeconds(_delay);        

        while (enabled)
        {
            yield return wait;
            var spawnPoint = Random.Range(0, _spawnPoints.Count);
            Enemy enemy= Instantiate(_prefab, _spawnPoints[spawnPoint].transform.position, Quaternion.identity);
            enemy.Init(_target);            
        }
    }
}
