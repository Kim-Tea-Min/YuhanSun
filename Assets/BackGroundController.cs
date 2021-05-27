using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    public GameObject smile;
    public GameObject f;
    private Vector3 smile_pos;

    public float rotationSpeed;
    public float moveSpeed;
    public float timer;

    private bool is_left = false;

    // Start is called before the first frame update
    void Start()
    {
        smile_pos = smile.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(smile.transform.position.y < smile_pos.y+30)
        smile.transform.Translate(new Vector3(0, moveSpeed, 0));
        else
        {
            smile.transform.position = smile_pos;
        }

        f.transform.Rotate(0, 0, -rotationSpeed);
        timer += Time.deltaTime;
        if (timer > 3)
        {
            timer = 0;
            rotationSpeed = -rotationSpeed;
        }
            
    }
}
