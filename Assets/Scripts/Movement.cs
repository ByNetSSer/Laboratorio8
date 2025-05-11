using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float horizontal;
    [SerializeField] private float vertical;
    [SerializeField] private int H = 0;
    [SerializeField] private int V = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (horizontal > 0) { H = 1; } else if (horizontal < 0) { H = -1; } else { H = 0; }
        if (vertical > 0) { V = 1; } else if (vertical < 0) { V = -1; } else { V = 0; }
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(H, V), 5, 3);
        Debug.DrawRay(transform.position, new Vector2(H, V) * hit.distance, Color.red);
    }
}
