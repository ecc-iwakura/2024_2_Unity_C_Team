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

            // �����������ʒu���w�肷�� (��: x���W��2�Ay���W��3�̈ʒu)
            Vector3 spawnPosition = new Vector3(-4.18f, 0.26f, 0.0f);

            // GameObject�𐶐�����
            GameObject spawnedObject = Instantiate(tori, spawnPosition, Quaternion.identity);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
