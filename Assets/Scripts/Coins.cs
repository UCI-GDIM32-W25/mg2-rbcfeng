using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Coins : MonoBehaviour
{
 [SerializeField] private float _speed = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        //float positionx = Random.Range(1f, 2f);
        //transform.position = new Vector3(transform.position.x - positionx, transform.position.y, transform.position.z);
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
        if(transform.position.x < -3f)
        {
            Destroy(this.gameObject);
        }
    }

}

   


        
    

