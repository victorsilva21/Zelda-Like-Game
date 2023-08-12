using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {


        _rb.velocity = (new Vector3(GetDirection().x, 0, GetDirection().z) * 150 * Time.deltaTime) + new Vector3(0, _rb.velocity.y, 0);




    }
    public Vector3 GetDirection()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float facing = Camera.main.transform.eulerAngles.y;
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;
        Vector3 myTurnedInputs = Quaternion.Euler(0, facing, 0) * direction;
        return myTurnedInputs;
    }
}
