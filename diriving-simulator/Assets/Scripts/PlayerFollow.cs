using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour

{
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 4, -10);
    }
}
