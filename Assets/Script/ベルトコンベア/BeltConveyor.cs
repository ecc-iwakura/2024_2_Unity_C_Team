using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltConveyor : MonoBehaviour
{
    public float speed = 3.0f;
    float diffX = 0.0f;
    private List<GameObject> gameObjects = new();

    public GameObject migi;
    public GameObject hidari;
    // Start is called before the first frame update
     
    

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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Instantiate(hidari, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        { 
            Instantiate(migi, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }
}
