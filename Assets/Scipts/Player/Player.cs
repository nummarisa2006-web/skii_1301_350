using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float ForcePower;

    [SerializeField]
    private Rigidbody rb;

    private InputAction moveAction;
    private Vector2 moveValue;

    [SerializeField]
    private int point;
    public int point {get { return point; } set { point = value; }  }

    [SerializeField]
    public int hp;

    public int HP {  get { return hp; } set {}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputAction.actions.FindAction("Move");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeftOrRight();
    }

    private void MoveLeftOrRight()
    {
        moveValue = moveAction.ReadValue<Vector2>();
        rb.AddForce(moveValue.x * Vector3.right * ForcePower);
    }
}
