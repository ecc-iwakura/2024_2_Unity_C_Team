using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reba : MonoBehaviour
{
    // Start is called before the first frame update
   //public GameObject clickedGameObject;//クリックされたゲームオブジェクトを代入する変数

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)||Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);//

            if (hit2d)
            {
               
            }

        }



    }
}
