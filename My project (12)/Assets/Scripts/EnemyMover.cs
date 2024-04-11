using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
   
    private void Update()
    {
        var direction = transform.forward.normalized;
        transform.Translate(direction * _speed, Space.World);
    }

    public Quaternion ChooseDirection()
    {
       return  Quaternion.Euler(0, Random.Range(0,361), 0);
    }
}
