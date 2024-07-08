using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toribougai_gomi : MonoBehaviour
{
    public GameObject tori;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sizai")
        {
            Destroy(collision.gameObject);

            // 生成したい位置を指定する (例: x座標が2、y座標が3の位置)
            Vector3 spawnPosition = new Vector3(-4.18f, 0.26f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(tori, spawnPosition, Quaternion.identity);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
