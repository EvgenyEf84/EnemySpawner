using UnityEngine;

public class DrawGizmos : MonoBehaviour
{
    [SerializeField] private Transform[] Points;
    [SerializeField] private Color GizmosColor;
    [SerializeField] private float Radius;

    private void OnDrawGizmos()
    {
        if (Points.Length == 0)
            return;

        foreach (var point in Points)
        {
            Gizmos.color = GizmosColor;
            Gizmos.DrawSphere(point.position, Radius);
        }
    }
}
