using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public float horizonatalInput;
    public float speed;
    public float xRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizonatalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * horizonatalInput * Time.deltaTime * speed);
        if (transform.position.x >= 23)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -23)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }
}
