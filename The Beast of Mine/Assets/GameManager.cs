﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

	public void Die( MsgManager TargetMsg , int MsgNumber)
    {

        SceneManager.LoadScene("LoadingScreen");
        //LoadLast Checkpoint
    }
}