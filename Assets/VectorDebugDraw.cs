using UnityEngine;

public class VectorDebugDraw : MonoBehaviour
{
    // Declare 4 public Vector3 fields for different points
    public Vector3 startPoint1 = new Vector3(0, 0, 0);
    public Vector3 endPoint1 = new Vector3(5, 5, 0);
    public Vector3 startPoint2 = new Vector3(2, 0, 0);
    public Vector3 endPoint2 = new Vector3(5, 2, 0);
    public Vector3 startPoint3 = new Vector3(-5, 0, 0);
    public Vector3 endPoint3 = new Vector3(0, -5, 0);
    public Vector3 startPoint4 = new Vector3(-10, 0, 0);
    public Vector3 endPoint4 = new Vector3(-5, 10, 0);

    // This will run once per frame
    void Update()
    {
        // Draw lines between the points
        Debug.DrawLine(startPoint1, endPoint1, Color.red);
        Debug.DrawLine(startPoint2, endPoint2, Color.green);
        Debug.DrawLine(startPoint3, endPoint3, Color.blue);
        Debug.DrawLine(startPoint4, endPoint4, Color.yellow);
    }
}
