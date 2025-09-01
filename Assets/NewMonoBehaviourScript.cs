using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float xForce = 5.0f;
    public float yForce = 100.0f;
    public float zForce = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x=0.0f, y=0.0f, z=0.0f;
        if(Input.GetKey(KeyCode.A))
        {
            x=x-xForce;
        }    
        if(Input.GetKey(KeyCode.D))
        {
            x=x+xForce;
        }
        if(Input.GetKey(KeyCode.W))
        {
            z=z-zForce;
        }
        if(Input.GetKey(KeyCode.S))
        {
            z=z+zForce;
        }
        if(Input.GetKey(KeyCode.Space))
        {
            y=yForce;
        }
        GetComponent<Rigidbody>().AddForce(x,y,z);
    }
}
