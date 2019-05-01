using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("enemyHead"))
        {
            Destroy(col.gameObject.transform.parent.gameObject);//Si llega la cabeza se destruye el padre
            //col.gameObject.des
            Debug.Log("otro muerto");
        }
    }

    
}
