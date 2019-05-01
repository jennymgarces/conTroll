using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class counter : MonoBehaviour
{
    public TextMeshProUGUI mytext;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        mytext.text = "Contador click: " + kill.countClick +"....."+kill.countClickEnemy;

    }
}
