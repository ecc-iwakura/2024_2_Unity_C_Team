using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizaibako : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "sugikahun")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "kurei")
        {
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.tag == "gugigugigu")
        {
            Destroy(collision.gameObject);
        }
    }
   
 }
