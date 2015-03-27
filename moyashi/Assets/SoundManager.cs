using UnityEngine;
using System.Collections;
using System;

public class SoundManager : MonoBehaviour {

    protected static SoundManager audioPlayer;

    public static SoundManager AudioPlayer
    {
       get
       {
           if(audioPlayer == null)
           {
               audioPlayer = (SoundManager)FindObjectOfType(typeof(SoundManager));
           }
           return audioPlayer;
       }
    }

    //オーディオソース
    private AudioSource BGMsource;
    private AudioSource[] SEsource = new AudioSource[16];

    //オーディオクリップ
    [SerializeField]
    private AudioClip[] bgm;
    [SerializeField]
    private AudioClip[] se;
    [SerializeField]
    private int maxSe = 10;

    void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("SoundManager");
        if (obj.Length > 1)
        {
            //SoundManagerあったら消えるよ
            Destroy(gameObject);
        }
        else
        {
            //シーン移行で消えないようにする
            DontDestroyOnLoad(gameObject);
        }

        //すべてのAudioSourceコンポーネント追加

        //BGMAudioSource
        BGMsource = gameObject.AddComponent<AudioSource>();
        //BGMのループ
        BGMsource.loop = true;

        //SE全てにAudioSourceをAddする
        for (int i = 0; i < SEsource.Length; i++)
        {
            SEsource[i] = gameObject.AddComponent<AudioSource>();
        }
        
    }


    
	// Use this for initialization
	void Start () {
       
        
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}
    
    //BGM再生用
    public void BGMPlay(int index)
    {
        if (0 > index || bgm.Length <= index)
        {
            return;
        }
    //同BGMだった場合再生しない
        if (BGMsource.clip == bgm[index])
        {
            return;
        }

        BGMsource.Stop();
        BGMsource.clip = bgm[index];
        BGMsource.Play();
    }

    public void BGMStop()
    {
        BGMsource.Stop();
        BGMsource.clip = null;
    }

    //SE再生用
    public void SEPlay(int index)
    {
        if (0 > index || se.Length <= index)
        {
            return;
        }
        foreach (AudioSource source in SEsource)
        {
            if (false == source.isPlaying)
            {
                source.clip = se[index];
                source.Play();
                return;
            }
        } 
    }

    ////SE停止
    //public void SEstop()
    //{
    //    //全SE停止
    //    foreach (AudioSource source in SEsource)
    //    {
    //        source.Stop();
    //        source.clip = null;
    //    }
    //}




   
}
