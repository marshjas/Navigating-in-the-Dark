using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        transform.position += new Vector3(moveSpeed * Input.GetAxis("Horizontal"), 0, 0);
        transform.position += new Vector3(0, moveSpeed * Input.GetAxis("Vertical"), 0);
    }
}
