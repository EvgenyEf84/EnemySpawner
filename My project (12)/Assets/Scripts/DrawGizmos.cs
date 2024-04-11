using UnityEngine;

public class DrawGizmos : MonoBehaviour
{
    public Transform[] Points;
    public Color GizmosColor;
    public float Radius;

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
