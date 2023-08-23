using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreBoardScript : MonoBehaviour
{       //得点を表示するテキスト
    private GameObject ScoreBoard;

    private int Score = 0;          // 得点


    // Start is called before the first frame update
    void Start()

    {
        Debug.Log(tag);


        //シーン中のScoreBoardオブジェクトを取得

        this.ScoreBoard = GameObject.Find("ScoreBoard");


        
    } 
   

// Update is called once per frame
void Update()
    {

    
    }
        
        //衝突時に呼ばれる関数
        
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

