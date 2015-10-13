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

    public static bool muerto=false;
    public static float Speed =5;
    public static int PTime=0;
    public static bool rayo = false;
    public static int score = 0;


	// Use this for initialization
	void Start () {
        if (!PlayerPrefs.HasKey("Name1") || !PlayerPrefs.HasKey("Name2") || !PlayerPrefs.HasKey("Name3") || !PlayerPrefs.HasKey("Name4") || !PlayerPrefs.HasKey("Name5") || !PlayerPrefs.HasKey("Name6") || !PlayerPrefs.HasKey("Name7") || !PlayerPrefs.HasKey("Name8") || !PlayerPrefs.HasKey("Name9") || !PlayerPrefs.HasKey("Name10"))
        {
            PlayerPrefs.SetString("Name1", "Name1");
            PlayerPrefs.SetInt("Score1", 0);
            PlayerPrefs.SetString("Name2", "Name1");
            PlayerPrefs.SetInt("Score2", 0);
            PlayerPrefs.SetString("Name3", "Name1");
            PlayerPrefs.SetInt("Score3", 0);
            PlayerPrefs.SetString("Name4", "Name1");
            PlayerPrefs.SetInt("Score4", 0);
            PlayerPrefs.SetString("Name5", "Name1");
            PlayerPrefs.SetInt("Score5", 0);
            PlayerPrefs.SetString("Name6", "Name1");
            PlayerPrefs.SetInt("Score6", 0);
            PlayerPrefs.SetString("Name7", "Name1");
            PlayerPrefs.SetInt("Score7", 0);
            PlayerPrefs.SetString("Name8", "Name1");
            PlayerPrefs.SetInt("Score8", 0);
            PlayerPrefs.SetString("Name9", "Name1");
            PlayerPrefs.SetInt("Score9", 0);
            PlayerPrefs.SetString("Name10", "Name1");
            PlayerPrefs.SetInt("Score10", 0);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
