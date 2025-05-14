using UnityEngine;
using UnityEngine.InputSystem;
public class CharacterControler3D : MonoBehaviour
{
    [SerializeField] private Rigidbody MyRGBD;
    [SerializeField] private float Speed;
    [SerializeField] private float JumpForce;
    [SerializeField] private Vector3 Vector;
    [SerializeField] private bool Canjump;
    [SerializeField] private LayerMask layer;
    [SerializeField] private  int distanceJump;
    private void Awake()
    {
        MyRGBD = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Physics.Raycast(transform.position, Vector3.down , distanceJump, layer))
        {
            
            Canjump = true;
        }
        Debug.DrawRay(transform.position, Vector3.down* distanceJump, Color.green);
        
    }
    private void FixedUpdate()
    {
        ApplyPhysics();
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector = new Vector3(context.ReadValue<Vector2>().x,0 , context.ReadValue<Vector2>().y);
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (Canjump)
        {
            MyRGBD.AddForce(Vector3.up * JumpForce);
            Canjump = false;
        }
        //MyRGBD.AddForce(Vector3.up * JumpForce);
    }
    public void ApplyPhysics()
    {
        Vector3 forcemovement = new Vector3(Vector.x, 0, Vector.z);
        //MyRGBD.linearVelocity = forcemovement * Speed;
        MyRGBD.AddForce(forcemovement * Speed);
    }
}
