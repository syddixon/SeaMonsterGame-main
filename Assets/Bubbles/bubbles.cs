using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbles : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float maxX = -19f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left);

        if (transform.position.x <= maxX)
        {
            transform.Translate(6f, 0f, 0f);
        }
    }
}
