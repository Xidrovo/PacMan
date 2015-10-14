using UnityEngine;
using System.Collections;


public class Atributos : MonoBehaviour {

    public enum Estados
    {
        PACMAN,
        HULK,
        AQUAMAN,
        BATMAN,
        DAREDEVIL,
        IRONMAN,
        SUPERMAN,
        FLASH
    };

    public static float Speed =5;
    public static int PTime=0;
    public static int rayo = 0;
    public static int score = 0;


	// Use this for initialization
	void Start () 
    {

	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
