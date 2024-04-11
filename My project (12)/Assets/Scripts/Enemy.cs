using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float _speed;

    public Transform _target;

    private void Update()
    {
        Move();
    }

    public virtual void Move()
    {
        transform.LookAt(_target);
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
