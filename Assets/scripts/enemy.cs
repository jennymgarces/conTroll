using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public float speed = 2f; //enemy speed 
    public float xLimit = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -xLimit, xLimit),
            transform.position.z);


    }

    /*void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("hola");
        if (col.gameObject.tag == "limit")
        {
            Destroy(gameObject);    
        }
    }*/
}
