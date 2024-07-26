using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Kesuzo : MonoBehaviour
{
    public GameObject Nerauhab;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,0.1f);
        Instantiate(Nerauhab, transform.position, transform.rotation);
    }
    
    //Vector3 mousePos, pos; //マウスとゲームオブジェクトの座標データを格納

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Sizai")
        //{
        //    Destroy(collision.gameObject);
        //}

        //if (collision.gameObject.tag == "Gomi")
        //{
        //    Destroy(collision.gameObject);
        //}

        if (collision.gameObject.tag == "bomu")
        {
            Destroy(collision.gameObject);
        }
    }
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.tag == "Gomi")
    //    {
    //        Destroy(other.gameObject);
    //    }
    //}


    // Update is called once per frame
    void Update()
    {
        //mousePos = Input.mousePosition;
        ////マウス位置を確認
        //Debug.Log(mousePos);
        ////スクリーン座標をワールド座標に変換する
        //pos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10f));
        ////ワールド座標をゲームオブジェクトの座標に設定する
        //transform.position = pos;
    }
}
