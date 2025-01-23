using System.IO;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRB;
    [SerializeField] private float ballSpeed = 10f;
    [SerializeField] private float jumpSpeed = 10f;
    private bool isTouching;
    
    void Start()
    {
        sphereRB = GetComponent<Rigidbody>();
    }
    private void OnCollisionStay()
    {
        isTouching = true;

    }
    public void MoveBall(Vector2 input)
    {
        Vector3 inputXYZPlane = new(input.x, 0, input.y);
        sphereRB.AddForce(inputXYZPlane * ballSpeed);

        if((Input.GetKey(KeyCode.Space)) && isTouching)
        {
            sphereRB.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            isTouching = false;
        }
    }  
}
