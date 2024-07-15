using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaiten : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public float Anglez = 0;
    public float maxAngle = 45.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {

            Vector3 worldAngle = transform.eulerAngles;
            // Z軸を中心に回転させる
            Anglez -= rotationSpeed;
            if (Anglez < -maxAngle)
            {
                Anglez = -maxAngle;

            }
            worldAngle.z = Anglez;
            transform.eulerAngles = worldAngle;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            Vector3 worldAngle = transform.eulerAngles;
            // Z軸を中心に回転させる
            Anglez += rotationSpeed;
            if (Anglez > maxAngle)
            {
                Anglez = maxAngle;

            }
            worldAngle.z = Anglez;
            transform.eulerAngles = worldAngle;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            // transformを取得
            Transform myTransform = this.transform;

            // ローカル座標を基準に、回転を取得
            Vector3 localAngle = myTransform.localEulerAngles;
            localAngle.x = 0.0f; // ローカル座標を基準にした、x軸を軸にした回転角度
            localAngle.y = 0.0f; // ローカル座標を基準にした、y軸を軸にした回転角度
            localAngle.z = 0.0f; // ローカル座標を基準にした、z軸を軸にした回転角度
            myTransform.localEulerAngles = localAngle; // 回転角度を設定
        }


        //// transformを取得
        //Transform myTransform = this.transform;

        //// ローカル座標を基準に、回転を取得
        //Vector3 localAngle = myTransform.localEulerAngles;
        //localAngle.x = 0.0f; // ローカル座標を基準にした、x軸を軸にした回転角度
        //localAngle.y = 0.0f; // ローカル座標を基準にした、y軸を軸にした回転角度
        //localAngle.z = 30.0f; // ローカル座標を基準にした、z軸を軸にした回転角度
        //myTransform.localEulerAngles = localAngle; // 回転角度を設定
    }
}
