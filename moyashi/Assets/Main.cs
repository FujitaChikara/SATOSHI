using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SoundManager.AudioPlayer.BGMPlay(0);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SoundManager.AudioPlayer.SEPlay(0);
        }
	
	}
}
