using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GomiMountain : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sizai")
        {
            
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Gomi")
        {
            
            Destroy(collision.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
