using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody sphereRB;
    public float ballSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Calling the Start method");
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Calling the Update method");

        Vector2 inputVector = Vector2.zero;

        if(Input.GetKey(KeyCode.W)) //up
        {
           // Debug.Log(Vector2.up);
            inputVector += Vector2.up;
        }

        if(Input.GetKey(KeyCode.A)) // left
        {
            //Debug.Log(Vector2.left);
            inputVector += Vector2.left;
        }
        
        if(Input.GetKey(KeyCode.S)) //down
        {
            //Debug.Log(Vector2.down);
            inputVector += Vector2.down;
        }
        
        if(Input.GetKey(KeyCode.D)) //right
        {
            //Debug.Log(Vector2.right);
            inputVector += Vector2.right;
        }

        Vector3 inputXYZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRB.AddForce(inputXYZPlane * ballSpeed);

        Debug.Log("Resultant Vector: "+ inputVector);
        Debug.Log("Resultant 3D Vector: "+ inputXYZPlane);

    }
}
