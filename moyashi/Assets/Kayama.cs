using UnityEngine;
using System.Collections;
using System;

public class Kayama : MonoBehaviour {



    public System.DayOfWeek week;
    public bool isDead;
    

	// Use this for initialization
	void Start () {
        isDead = false;
        week = DateTime.Now.DayOfWeek;
	}
	
	// Update is called once per frame
	void Update () 
    {
        
        switch (week)
        {
            case DayOfWeek.Monday:
                Fujiya();
                isDead = true;
                return;

            case DayOfWeek.Tuesday:
                Fujiya();
                isDead = true;
                return;

            case DayOfWeek.Wednesday:
                Fujiya();
                isDead = true;
                return;

            case DayOfWeek.Thursday:
                Fujiya();
                isDead = true;
                return;

            case DayOfWeek.Friday:
                Fujiya();
                isDead = true;
                return;

            case DayOfWeek.Saturday:
                Teils();
                isDead = true;
                return;

            case System.DayOfWeek.Sunday:
                Teils();
                isDead = true;
                return;
        }

        Alive();
	}

    void Fujiya()
    {
        Cook();
    }

    void Cook()
    {

    }

    void Alive()
    {
        if (isDead)
        {
            Destroy(gameObject);
        }
    }

    void Teils()
    {
    }
}
