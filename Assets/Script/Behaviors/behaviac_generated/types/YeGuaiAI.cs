﻿// -------------------------------------------------------------------------------
// THIS FILE IS ORIGINALLY GENERATED BY THE DESIGNER.
// YOU ARE ONLY ALLOWED TO MODIFY CODE BETWEEN '///<<< BEGIN' AND '///<<< END'.
// PLEASE MODIFY AND REGENERETE IT IN THE DESIGNER FOR CLASS/MEMBERS/METHODS, ETC.
// -------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

///<<< BEGIN WRITING YOUR CODE FILE_INIT
using UnityEngine;
///<<< END WRITING YOUR CODE

public class YeGuaiAI : behaviac.Agent
///<<< BEGIN WRITING YOUR CODE YeGuaiAI
///<<< END WRITING YOUR CODE
{
	public void Attack()
	{
///<<< BEGIN WRITING YOUR CODE Attack
        Debug.Log("Attack==>");
///<<< END WRITING YOUR CODE
	}

	public behaviac.EBTStatus BackHome()
	{
///<<< BEGIN WRITING YOUR CODE BackHome
        Debug.Log("BackHome==>");
        if (true)
        {
            return behaviac.EBTStatus.BT_SUCCESS;
        }
        return behaviac.EBTStatus.BT_RUNNING;
///<<< END WRITING YOUR CODE
	}

	public behaviac.EBTStatus FindEnmey()
	{
///<<< BEGIN WRITING YOUR CODE FindEnmey
        Debug.Log("FindEnmey==>" );
        if (true)
        {
            return behaviac.EBTStatus.BT_SUCCESS;
        }
        return behaviac.EBTStatus.BT_RUNNING;
///<<< END WRITING YOUR CODE
	}

	public behaviac.EBTStatus IsOutRang()
	{
///<<< BEGIN WRITING YOUR CODE IsOutRang
        Debug.Log("IsOutRang==>" );
        if (true)
        {
            return behaviac.EBTStatus.BT_SUCCESS;
        }
        return behaviac.EBTStatus.BT_FAILURE;
///<<< END WRITING YOUR CODE
	}

	public bool PursuitOrAttack()
	{
///<<< BEGIN WRITING YOUR CODE PursuitOrAttack
        Debug.Log("PursuitOrAttack==>");
        if (true)
        {
            return true;
        }
        return false;
///<<< END WRITING YOUR CODE
	}

	public void Pursuit()
	{
///<<< BEGIN WRITING YOUR CODE Pursuit
        Debug.Log("Pursuit==>");
///<<< END WRITING YOUR CODE
	}

///<<< BEGIN WRITING YOUR CODE CLASS_PART
    void Awake()
    {
        InitBehavic();
        InitPlayer();
    }

    private bool InitBehavic()
    {
        Debug.Log("InitBehavic======>" + ExportedFilePath);
        behaviac.Workspace.Instance.FilePath = ExportedFilePath;
        behaviac.Workspace.Instance.FileFormat = behaviac.Workspace.EFileFormat.EFF_xml;

        return true;
    }

    private static string ExportedFilePath
    {
        get
        {
            string relativePath = "/Resources/BehaviorsExported";// 
            if (Application.platform == RuntimePlatform.WindowsEditor)
            {
                return Application.dataPath + relativePath;
            }
            else if (Application.platform == RuntimePlatform.WindowsPlayer)
            {
                return Application.dataPath + relativePath;
            }
            else
            {
                return "Assets" + relativePath;
            }
        }
    }

    private bool InitPlayer()
    {
        Debug.Log("InitPlayer===========");

        bool bRet = this.btload("YeGuaiAI");
        if (bRet)
        {
            this.btsetcurrent("YeGuaiAI");
        }

        return bRet;
    }

    behaviac.EBTStatus _status = behaviac.EBTStatus.BT_RUNNING;
    void Update()
    {
        if (_status == behaviac.EBTStatus.BT_RUNNING)
        {
            Debug.LogWarning("Update===============================================");
            _status = this.btexec();
        }
    }
///<<< END WRITING YOUR CODE

}

///<<< BEGIN WRITING YOUR CODE FILE_UNINIT

///<<< END WRITING YOUR CODE

