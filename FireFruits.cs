using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFruits : MonoBehaviour
{
    public GameObject[] obj;
    int range;
    // Start is called before the first frame update
    void Start()
    {
        range = Random.Range(0, obj.Length);
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(obj[range], transform.position, obj[range].transform.rotation);
        }

    }
}
 
