using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScubaDiver : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float MinY = -4f;
    [SerializeField] float MaxY = 4f;
    [SerializeField] GameObject anchorPrefab;
    [SerializeField] Vector3 anchorPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");

        //transform.Translate(0f, Time.deltaTime * y, 0f);
        transform.Translate(Time.deltaTime * speed * y * Vector3.up);

        //object doesn't go passed MaxY
        if (transform.position.y > MaxY)
        {
            transform.position = new Vector3(transform.position.x, MaxY, 0f);
        }

        //object doesn't go passed MinY
        if (transform.position.y < MinY)
        {
            transform.position = new Vector3(transform.position.x, MinY, 0f);
        }
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(anchorPrefab, transform.position + anchorPos, transform.rotation);
        }
    }
}
