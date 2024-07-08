using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidariHidari_2 : MonoBehaviour
{
    bool moveTrigger;
    public float speed = 3.0f;
    float diffX = 0.0f;
    private List<GameObject> gameObjects = new();
    public GameObject hidaripurehabu;
    public GameObject seishigazou;
    public float cooltime = 1.5f;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        diffX = speed * Time.fixedDeltaTime;
        moveTrigger = true;
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
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow) && timer >= cooltime)
        {
            //Instantiate(hidaripurehabu, transform.position, transform.rotation);
            //Destroy(gameObject);
            //moveTrigger = false;
            //Invoke("MoveRestart", 2.0f);
            diffX = speed * Time.fixedDeltaTime;
            timer = 0;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && timer >= cooltime)
        {
            //Instantiate(hidaripurehabu, transform.position, transform.rotation);
            //Destroy(gameObject);
            //moveTrigger = false;
            //Invoke("MoveRestart", 2.0f);
            diffX = -speed * Time.fixedDeltaTime;
            timer = 0;
        }
        //else if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    Instantiate(seishigazou, transform.position, transform.rotation);
        //    Destroy(gameObject);
        //}
    }
    void MoveRestart()
    {
        moveTrigger = true;
    }
}
