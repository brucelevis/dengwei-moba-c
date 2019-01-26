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
using TrueSync;
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
	/// <summary>
	/// 这个Actor身上所有的属性
	/// </summary>
	public ActorAttr mActorAttr = new ActorAttr();

	/// <summary>
	/// 这个Actor身上所有的Buff
	/// </summary>
	public ActorBuffManager mActorBuffManager = new ActorBuffManager();

	/// <summary>
	/// 初始化可能被频繁用到的预制体(因为常用,让他一直在内存里)
	/// </summary>
	protected void InitWillUsedPrefabs() { 
	}

	public uint Id { set; get; }

	/// <summary>
	/// 模型
	/// </summary>
	private GameObject mActorObj;
	public GameObject ActorObj
	{
		get
		{
			if (mActorObj == null)
				mActorObj = transform.Find("rotate/actor").gameObject;
			return mActorObj;
		}
	}

	private Animation mActorAnimation;
	/// <summary>
	/// 动画播放控件(控制一个动画的播放)
	/// </summary>
	public Animation ActorAnimation
	{
		get
		{
			if (mActorAnimation == null)
				mActorAnimation = ActorObj.GetComponent<Animation>();
			return mActorAnimation;
		}
	}

	private TSTransform mRotateTSTransform;
	public TSTransform RotateTSTransform
	{
		get
		{
			if (mRotateTSTransform == null)
			{
				mRotateTSTransform = transform.Find("rotate").transform.GetComponent<TSTransform>();
			}
			return mRotateTSTransform;
		}
	}

	private TSTransform mAllTSTransform;
	public TSTransform AllTSTransform
	{
		get
		{
			if (mAllTSTransform == null)
			{
				mAllTSTransform = GetComponent<TSTransform>();
			}
			return mAllTSTransform;
		}
	}

	behaviac.EBTStatus _status = behaviac.EBTStatus.BT_RUNNING;

	void Awake()
    {
        InitBehavic();
        InitPlayer();
		InitWillUsedPrefabs();
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

	public override void OnSyncedUpdate()
    {
        if (_status == behaviac.EBTStatus.BT_RUNNING)
        {
            Debug.LogWarning("Update===============================================");
            _status = this.btexec();
        }
    }

	#region 位置相关
	public bool IsMove { get; set; }

	public FP Speed
	{
		set
		{
			mActorAttr.Speed = value;
		}
		get
		{
			return mActorAttr.Speed;
		}
	}

	public TSVector Angle { set; get; }
	#endregion 位置相关

	#region TrueSyncBehaviour操作相关
	public override void OnSyncedStart()
	{
		Debug.LogErrorFormat("YeGuaiAI====>OnSyncedStart");
	}

	public void OnSyncedCollisionEnter(TSCollision other)
	{
		other.gameObject.GetComponent<Renderer>().material.color = Color.gray;
		Debug.LogErrorFormat("YeGuaiAI====>Collision   Enter==>{0}", other.gameObject.name);
	}

	public void OnSyncedCollisionStay(TSCollision other)
	{
		Debug.LogErrorFormat("YeGuaiAI====>Collision   Stay==>{0}", other.gameObject.name);
	}

	public void OnSyncedCollisionExit(TSCollision other)
	{
		other.gameObject.GetComponent<Renderer>().material.color = Color.blue;
		Debug.LogErrorFormat("YeGuaiAI====>Collision   Exit==>{0}", other.gameObject.name);
	}

	public void OnSyncedTriggerEnter(TSCollision other)
	{
		Debug.LogErrorFormat("YeGuaiAI====>Trigger  Enter==>{0}", other.gameObject.name);
	}

	public void OnSyncedTriggerStay(TSCollision other)
	{
		Debug.LogErrorFormat("YeGuaiAI====>Trigger  Stay==>{0}", other.gameObject.name);
	}

	public void OnSyncedTriggerExit(TSCollision other)
	{
		Debug.LogErrorFormat("YeGuaiAI====>Trigger  Exit==>{0}", other.gameObject.name);
	}

	#endregion TrueSyncBehaviour操作相关

///<<< END WRITING YOUR CODE

}

///<<< BEGIN WRITING YOUR CODE FILE_UNINIT

///<<< END WRITING YOUR CODE

