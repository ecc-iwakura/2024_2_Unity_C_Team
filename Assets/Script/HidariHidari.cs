using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidariHidari : MonoBehaviour
{
    public float speed = 3.0f;
    float diffX = 0.0f;
    private List<GameObject> gameObjects = new();
    public GameObject hidaripurehabu;
    public GameObject seishigazou;
    // Start is called before the first frame update
    void Start()
    {
        diffX = speed * Time.fixedDeltaTime;
    }

    private void FixedUpdate()
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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Instantiate(hidaripurehabu, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    //    else if (Input.GetKeyDown(KeyCode.DownArrow))
    //    {
    //        Instantiate(seishigazou, transform.position, transform.rotation);
    //        Destroy(gameObject);
    //    }
    }
}
