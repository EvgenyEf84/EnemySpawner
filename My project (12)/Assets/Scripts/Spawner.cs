using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _delay;
    [SerializeField] private List<Transform> _spawnPoints;

    void Start()
    {
        _spawnPoints = new List<Transform>(_spawnPoints);
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(_delay);
            var spawnPoint = Random.Range(0, _spawnPoints.Count);
            Instantiate(_prefab, _spawnPoints[spawnPoint].transform.position, _spawnPoints[spawnPoint].transform.rotation);             
        }
    }
}
