using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class MoveObject : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5.0f; //이동속도
    public float jumpForce = 5.0f; //점프힘

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * speed * Time.deltaTime;

        transform.Translate(new Vector3(0, 0, 0.08f));

        if(Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector3.up *jumpForce ,ForceMode.Impulse);

            
        if(Input.GetKeyDown(KeyCode.Q)){
            transform.eulerAngles -= new Vector3(0, 90, 0);

        }
        if(Input.GetKeyDown(KeyCode.E)){
            transform.eulerAngles += new Vector3(0, 90, 0);
        }
    }
}
