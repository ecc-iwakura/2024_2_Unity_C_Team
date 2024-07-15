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
            // Z���𒆐S�ɉ�]������
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
            // Z���𒆐S�ɉ�]������
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
            // transform���擾
            Transform myTransform = this.transform;

            // ���[�J�����W����ɁA��]���擾
            Vector3 localAngle = myTransform.localEulerAngles;
            localAngle.x = 0.0f; // ���[�J�����W����ɂ����Ax�������ɂ�����]�p�x
            localAngle.y = 0.0f; // ���[�J�����W����ɂ����Ay�������ɂ�����]�p�x
            localAngle.z = 0.0f; // ���[�J�����W����ɂ����Az�������ɂ�����]�p�x
            myTransform.localEulerAngles = localAngle; // ��]�p�x��ݒ�
        }


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
