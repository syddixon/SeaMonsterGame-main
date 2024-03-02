using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterShooter : MonoBehaviour
{
   	[SerializeField] float speed = 0.01f;
    [SerializeField] float minY = -4f;
    [SerializeField] float maxY = 4f;
    [SerializeField] GameObject monsterPrefab;
    [SerializeField] float randVarMax;
    [SerializeField] float randVarMin;
	
	bool travelDirection = true;
	float futureTime = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	 if(travelDirection == true)
        {//moving up
            transform.Translate(speed * Vector3.up);
        }
        else
        {//moving down
            transform.Translate(speed * Vector3.down);
        }
        //if hit the top, change direction
        if(transform.position.y > maxY)
        {
            travelDirection = false;
        }
        //if hit bottom, change direction
        if(transform.position.y < minY)
        {
            travelDirection = true;
        }
         if(Time.time > futureTime) //if current time is greator than the futureTime variable
        {
            futureTime = Time.time + Random.Range(randVarMin, randVarMax);
            Instantiate(monsterPrefab, transform.position, transform.rotation);
        }
    }
}
