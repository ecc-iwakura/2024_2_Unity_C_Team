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
    
    //Vector3 mousePos, pos; //�}�E�X�ƃQ�[���I�u�W�F�N�g�̍��W�f�[�^���i�[

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
        ////�}�E�X�ʒu���m�F
        //Debug.Log(mousePos);
        ////�X�N���[�����W�����[���h���W�ɕϊ�����
        //pos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10f));
        ////���[���h���W���Q�[���I�u�W�F�N�g�̍��W�ɐݒ肷��
        //transform.position = pos;
    }
}
