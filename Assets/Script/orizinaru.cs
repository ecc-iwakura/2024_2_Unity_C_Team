using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orizinaru : MonoBehaviour
{
    [SerializeField]float Power;
    List<Rigidbody2D> rigidbody2Ds = new List<Rigidbody2D>();
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2Ds = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Power =-Mathf.Abs(Power);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Power = Mathf.Abs(Power);
        }
        if(rigidbody2Ds != null)
        {
            foreach (var rigidbody in rigidbody2Ds)
            {
                rigidbody.velocity = (new(Power, 0));
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(rigidbody2Ds == null)
        {
            rigidbody2Ds= new List<Rigidbody2D>();
        }
        rigidbody2Ds.Add(collision.gameObject.GetComponent<Rigidbody2D>());
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Rigidbody2D rigidbody2D = collision.gameObject.GetComponent<Rigidbody2D>();
        for (int i = 0; i < rigidbody2Ds.Count; i++)
        {
            if (rigidbody2Ds[i]== rigidbody2D)
            {
                rigidbody2Ds.RemoveAt(i); 
                break;
            }
        }
        
    }
    //private void OnCollisionStay2D(Collision2D collision)
    //{
    //    collision.gameObject.GetComponent<Rigidbody2D>().velocity = (new(Power, 0));
    //}
}
