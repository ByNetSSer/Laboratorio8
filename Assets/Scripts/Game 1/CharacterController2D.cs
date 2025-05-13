using UnityEngine;
using UnityEngine.InputSystem;
public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRgbd2d;
    [SerializeField] private float velocity;
    [SerializeField] private Vector2 Vector;
    private void Awake()
    {
        myRgbd2d = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        myRgbd2d.AddForce((Vector * velocity));
    }
    public void Onmovement(InputAction.CallbackContext context)
    {
        Vector = context.ReadValue<Vector2>();
        //myRgbd2d.AddForce(context.ReadValue<Vector2>()*velocity);
    }
}
