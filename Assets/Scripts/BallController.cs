using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRB;
    [SerializeField] private float ballSpeed = 2f;
    
    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXYZPlane = new(input.x, 0, input.y);
        sphereRB.AddForce(inputXYZPlane * ballSpeed);
    }
    
}
