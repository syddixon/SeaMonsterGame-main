using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish1 : MonoBehaviour
{
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left);
	}
		
//	private void OnCollisionEnter2D(Collision2D collision)
//	{
//		AudioSource audioSource;
//		audioSource = GetComponent<AudioSource>();
//			
//		audioSource.Play();
//	}

}

