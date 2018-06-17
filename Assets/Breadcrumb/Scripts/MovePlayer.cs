using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.1f);
            transform.position = newPos;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f);
            transform.position = newPos;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 newPos = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
            transform.position = newPos;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 newPos = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
