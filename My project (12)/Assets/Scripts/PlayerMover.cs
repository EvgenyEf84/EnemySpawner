using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private List<Transform> _wayPoints;
    [SerializeField] private float _speed;
    private int _currentWayPoint = 0;

    private void Update()
    {
        if (transform.position == _wayPoints[_currentWayPoint].position)
        {
            _currentWayPoint = (_currentWayPoint + 1) % _wayPoints.Count;
        }

        transform.LookAt(_wayPoints[_currentWayPoint].position);
        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_currentWayPoint].position, _speed * Time.deltaTime);
    }
}
