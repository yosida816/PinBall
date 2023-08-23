using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreBoardScript : MonoBehaviour
{       //���_��\������e�L�X�g
    private GameObject ScoreBoard;

    private int Score = 0;          // ���_


    // Start is called before the first frame update
    void Start()

    {
        Debug.Log(tag);


        //�V�[������ScoreBoard�I�u�W�F�N�g���擾

        this.ScoreBoard = GameObject.Find("ScoreBoard");


        
    } 
   

// Update is called once per frame
void Update()
    {

    
    }
        
        //�Փˎ��ɌĂ΂��֐�
        
    void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "SmallStarTag")
            {
            AddScore(10);
        }
            else if (other.gameObject.tag == "LargeStarTag")
            {
            AddScore(20);
        }
            else if (other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag")
            {
            AddScore(30);
        }
       
    }
    void AddScore(int amount)
    {
        Score += amount;

        this.ScoreBoard.GetComponent<Text>().text = "Score:" + Score;


    }


        
        
        
    }

