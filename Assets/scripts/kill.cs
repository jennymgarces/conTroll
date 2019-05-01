using System;
using System.Collections;
using System.Collections.Generic;
//using Unity.UNetWeaver;
using UnityEngine;
//Catch the touch, it`s the touch counter 
public class kill : MonoBehaviour
{
    
    public static int countClick = 0;//This is used for controller manager
    public static int countClickEnemy = 0;//This is used for controller manager
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0){
            //print("ther is a touch");
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                countClick++;
                //print("Touch has Began");
                Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
                if (Physics2D.Raycast(pos,  Vector2.zero))
                    if (hit.collider.CompareTag("enemyHead"))
                    {
                        Destroy(hit.transform.parent.gameObject);//Si llega la cabeza se destruye el padre
                        //Debug.Log("touch head");
                        countClickEnemy++;
                    }
                    else if (hit.collider.CompareTag("enemyBody"))
                    {
                         //Debug.Log("touch body");
                        countClickEnemy++;
                    }
                
               // }
            }
        }
    }
}
