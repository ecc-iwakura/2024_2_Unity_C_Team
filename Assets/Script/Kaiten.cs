using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaiten : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public float Anglez = 0;
    public float def = 0.0f;
    public float maxAngle = 45.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            Vector3 worldAngle = transform.eulerAngles;
        if (Input.GetKey(KeyCode.RightArrow))
        {

            // Z���𒆐S�ɉ�]������
            Anglez -= rotationSpeed;
            if (Anglez < -maxAngle)
            {
                Anglez = -maxAngle;

            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {

            // Z���𒆐S�ɉ�]������
            Anglez += rotationSpeed;
            if (Anglez > maxAngle)
            {
                Anglez = maxAngle;

            }
        }
        else
        {
            Anglez *= 0.99f;

        }
        worldAngle.z = Anglez;
        transform.eulerAngles = worldAngle;

        //else if (Anglez > def)
        //{
        //    Vector3 worldAngle = transform.eulerAngles;
        //    Anglez += rotationSpeed;
        //    //if (Anglez < def)
        //    //{
        //    //    Anglez = def;
        //    //}

        //    worldAngle.z = Anglez;
        //    transform.eulerAngles = worldAngle;


        //}

        //if(Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    // transform���擾
        //    Transform myTransform = this.transform;

        //    // ���[�J�����W����ɁA��]���擾
        //    Vector3 localAngle = myTransform.localEulerAngles;
        //    localAngle.x = 0.0f; // ���[�J�����W����ɂ����Ax�������ɂ�����]�p�x
        //    localAngle.y = 0.0f; // ���[�J�����W����ɂ����Ay�������ɂ�����]�p�x
        //    localAngle.z = 0.0f; // ���[�J�����W����ɂ����Az�������ɂ�����]�p�x
        //    myTransform.localEulerAngles = localAngle; // ��]�p�x��ݒ�
        //}


        //// transform���擾
        //Transform myTransform = this.transform;

        //// ���[�J�����W����ɁA��]���擾
        //Vector3 localAngle = myTransform.localEulerAngles;
        //localAngle.x = 0.0f; // ���[�J�����W����ɂ����Ax�������ɂ�����]�p�x
        //localAngle.y = 0.0f; // ���[�J�����W����ɂ����Ay�������ɂ�����]�p�x
        //localAngle.z = 30.0f; // ���[�J�����W����ɂ����Az�������ɂ�����]�p�x
        //myTransform.localEulerAngles = localAngle; // ��]�p�x��ݒ�
    }
}
