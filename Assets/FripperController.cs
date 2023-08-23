using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;

    //�����̌X��
    private float defaultAngle = 20.0f;
    //�e�������̌X��
    private float flickAngle = -20.0f;

    // Start is called before the first frame update
    void Start()
    {
        //HingeJoint�R���|�[�l���g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {

        //�����L�[�������������t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        else if (Input.GetKeyDown(KeyCode.A)&& tag == "LeftFripperTag")
        { SetAngle(this.flickAngle); }
         else if (Input.GetKeyDown(KeyCode.S)&& tag == "LeftFripperTag")
        { SetAngle(this.flickAngle); }

        
        //�E���L�[�����������E�t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        else if (Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag")
        { SetAngle(this.flickAngle); }
        else if (Input.GetKeyDown(KeyCode.S) && tag == "RightFripperTag")
        { SetAngle(this.flickAngle); }

        //���L�[�����ꂽ���t���b�p�[�����ɖ߂�
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        else if (Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag")
        { SetAngle(this.defaultAngle); }
        else if (Input.GetKeyUp(KeyCode.S) && tag == "LeftFripperTag")
        { SetAngle(this.defaultAngle); }


        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        else if (Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag")
      
        { SetAngle(this.defaultAngle); }
        else if (Input.GetKeyUp(KeyCode.S) && tag == "RightFripperTag")
      
        { SetAngle(this.defaultAngle); }
        
    }

    //�t���b�p�[�̌X����ݒ�
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}