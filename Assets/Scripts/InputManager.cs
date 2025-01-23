using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();

    void Update()
    {
        Vector2 inputVector = Vector2.zero;
        if(Input.GetKey(KeyCode.W)) //up
        {
            inputVector += Vector2.up;
        }
        if(Input.GetKey(KeyCode.A)) // left
        {
            inputVector += Vector2.left;
        }
        if(Input.GetKey(KeyCode.S)) //down
        {
            inputVector += Vector2.down;
        }
        if(Input.GetKey(KeyCode.D)) //right
        {
            inputVector += Vector2.right;
        }

        OnMove?.Invoke(inputVector);
        
    }
}
