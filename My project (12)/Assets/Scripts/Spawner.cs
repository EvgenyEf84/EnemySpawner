using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private float _delay;
    [SerializeField] private List<Transform> _spawnPoints;

    Mover direction;


    private void Start()
    {
        _spawnPoints = new List<Transform>(_spawnPoints); 
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        var wait = new WaitForSeconds(_delay);
       
        while (true)
        {
            yield return wait;
            var spawnPoint = Random.Range(0, _spawnPoints.Count);
            Instantiate(_prefab, _spawnPoints[spawnPoint].transform.position , direction.ChooseDirection());             
        }
    }
}
