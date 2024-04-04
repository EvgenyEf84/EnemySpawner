using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        var direction = transform.forward.normalized;
        transform.Translate(direction * _speed, Space.World);
    }
}
