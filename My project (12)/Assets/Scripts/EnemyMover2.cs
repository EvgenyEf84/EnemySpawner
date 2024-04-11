using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyMover2 : Enemy
{
    private void Update()
    {
        Move();
    }

    public override void Move()
    {
        transform.LookAt(_target);
        transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
    }
}
