using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mausuoikake : MonoBehaviour
{
    public GameObject kesuhab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
        //Vector3 mousePos, pos; //マウスとゲームオブジェクトの座標データを格納

  void Update()
  {
            //マウスの座標を取得する
            //mousePos = Input.mousePosition;
            ////マウス位置を確認
            //Debug.Log(mousePos);
            ////スクリーン座標をワールド座標に変換する
            //pos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10f));
            ////ワールド座標をゲームオブジェクトの座標に設定する
            //transform.position = pos;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(kesuhab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
  }
   
}
