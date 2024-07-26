using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Siso : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Transform myTransform = this.transform;

            // ローカル座標を基準に、回転を取得
            Vector3 localAngle = myTransform.localEulerAngles;
            localAngle.x = 0.0f; // ローカル座標を基準にした、x軸を軸にした回転角度
            localAngle.y = 0.0f; // ローカル座標を基準にした、y軸を軸にした回転角度
            localAngle.z = -30.0f; // ローカル座標を基準にした、z軸を軸にした回転角度
            myTransform.localEulerAngles = localAngle; // 回転角度を設定

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Transform myTransform = this.transform;

            // ローカル座標を基準に、回転を取得
            Vector3 localAngle = myTransform.localEulerAngles;
            localAngle.x = 0.0f; // ローカル座標を基準にした、x軸を軸にした回転角度
            localAngle.y = 0.0f; // ローカル座標を基準にした、y軸を軸にした回転角度
            localAngle.z = 30.0f; // ローカル座標を基準にした、z軸を軸にした回転角度
            myTransform.localEulerAngles = localAngle; // 回転角度を設定

        }
    }
}
