using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    float steerSpeed = 2;
    [SerializeField] float movingSpeed = 0.3f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float moveH = Input.GetAxis("Horizontal") * steerSpeed;
        float moveV = Input.GetAxis("Vertical") * movingSpeed;
        transform.Rotate(0, 0, -moveH);
        transform.Translate(0,moveV,0);
        
    }
}
