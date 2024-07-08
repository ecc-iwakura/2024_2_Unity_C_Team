using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor_randamukiri : MonoBehaviour
{
    public float speed = 1.0f;

    float diffX = 0.0f;
    private List<GameObject> gameObjects = new();

    // Start is called before the first frame update

    private float timer = 0.0f;
    public float change_time = 3.5f;

    void Start()
    {
        diffX = speed * Time.fixedDeltaTime;
    }

    // Update is called once per frame

    private void Update()
    {
        foreach (GameObject gameObject in gameObjects)
        {
            if (gameObject)
            {
                Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
                rb.position += new Vector2(diffX, 0);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>() != null)
        {
            gameObjects.Add(collision.gameObject);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (gameObjects.Contains(collision.gameObject))
        {
            gameObjects.Remove(collision.gameObject);
        }
    }

    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;

        if (timer > change_time)
        {
            //int rnd = Random.Range(0, 2);
            //if (rnd == 1) 
            //{
            //    return;
            //    timer=0.0f;
            //}
            diffX = -diffX;
            timer= 0.0f;
        }
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    Instantiate(hidari, transform.position, transform.rotation);
        //    Destroy(gameObject);
        //}

        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    Instantiate(migi, transform.position, transform.rotation);
        //    Destroy(gameObject);
        //}

    }


}
