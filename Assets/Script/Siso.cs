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

            // ���[�J�����W����ɁA��]���擾
            Vector3 localAngle = myTransform.localEulerAngles;
            localAngle.x = 0.0f; // ���[�J�����W����ɂ����Ax�������ɂ�����]�p�x
            localAngle.y = 0.0f; // ���[�J�����W����ɂ����Ay�������ɂ�����]�p�x
            localAngle.z = -30.0f; // ���[�J�����W����ɂ����Az�������ɂ�����]�p�x
            myTransform.localEulerAngles = localAngle; // ��]�p�x��ݒ�

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Transform myTransform = this.transform;

            // ���[�J�����W����ɁA��]���擾
            Vector3 localAngle = myTransform.localEulerAngles;
            localAngle.x = 0.0f; // ���[�J�����W����ɂ����Ax�������ɂ�����]�p�x
            localAngle.y = 0.0f; // ���[�J�����W����ɂ����Ay�������ɂ�����]�p�x
            localAngle.z = 30.0f; // ���[�J�����W����ɂ����Az�������ɂ�����]�p�x
            myTransform.localEulerAngles = localAngle; // ��]�p�x��ݒ�

        }
    }
}
