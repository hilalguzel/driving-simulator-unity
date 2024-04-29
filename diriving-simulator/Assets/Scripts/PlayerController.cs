using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //We will move the vehicle forward
        // transform.Translate(0,0,1);


        //We get change according to time (1m forward per second)
        transform.Translate(Vector3.forward * Time.deltaTime * 20);  //and for speed *20
    }
}
