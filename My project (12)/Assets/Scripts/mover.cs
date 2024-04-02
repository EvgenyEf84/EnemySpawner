using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private void Update()
    {
        var direction = transform.forward.normalized;
        transform.Translate(direction * _speed, Space.World);
        //var nextPosition = transform.position;
        //nextPosition.z += 0.05f;
        //transform.position = nextPosition;
    }
}
