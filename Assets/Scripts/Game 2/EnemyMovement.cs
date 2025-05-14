using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Vector3[] pivotPoints;
    [SerializeField] int ActualPoint;
   // [SerializeField] Rigidbody rb;
    [SerializeField] private int velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
        UpdatePivot();
    }
    private void move()
    {
        transform.position = Vector3.MoveTowards(transform.position, pivotPoints[ActualPoint], velocity * Time.deltaTime);
    }
    private void UpdatePivot()
    {
        if (Vector3.Distance(transform.position, pivotPoints[ActualPoint]) < 0.1f)
        {
            if (ActualPoint + 1 < pivotPoints.Length)
            {
                ActualPoint++;
            }
            else
            {
                ActualPoint = 0;
            }

        }
    }
}
