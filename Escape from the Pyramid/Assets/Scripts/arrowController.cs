using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowController : MonoBehaviour
{
    public int startingPosition = 0;
    public int movement = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movement = 1;

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movement = -1;

        }
        else
        {
            movement = 0;
        }

        if (movement == -1)
        {
            if (startingPosition < 4)
            {
                transform.Translate(new Vector3(0, -8, 0));
                startingPosition += 1;
            }
            else
            {
                transform.Translate(new Vector3(0, 32, 0));
                startingPosition -= 4;
            }

        }
        else if (movement == 1)
        {
            if (startingPosition > 0)
            {
                transform.Translate(new Vector3(0, 8, 0));
                startingPosition -= 1;
            }
            else
            {
                transform.Translate(new Vector3(0, -32, 0));
                startingPosition += 4;
            }
        }
    }

    void FixedUpdate()
    {
    }
}
