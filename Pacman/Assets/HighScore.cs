using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {

    public Text Name1, Name2, Name3, Name4, Name5, Name6, Name7, Name8, Name9, Name10, Score1, Score2, Score3, Score4, Score5, Score6, Score7, Score8, Score9, Score10;

	// Use this for initialization
	void Start () 
    {
        Name1.text = PlayerPrefs.GetString("Name1");
        Name2.text = PlayerPrefs.GetString("Name2");
        Name3.text = PlayerPrefs.GetString("Name3");
        Name4.text = PlayerPrefs.GetString("Name4");
        Name5.text = PlayerPrefs.GetString("Name5");
        Name6.text = PlayerPrefs.GetString("Name6");
        Name7.text = PlayerPrefs.GetString("Name7");
        Name8.text = PlayerPrefs.GetString("Name8");
        Name9.text = PlayerPrefs.GetString("Name9");
        Name10.text = PlayerPrefs.GetString("Name10");
        Score1.text = "" + PlayerPrefs.GetInt("Score1");
        Score2.text = "" + PlayerPrefs.GetInt("Score2");
        Score3.text = "" + PlayerPrefs.GetInt("Score3");
        Score4.text = "" + PlayerPrefs.GetInt("Score4");
        Score5.text = "" + PlayerPrefs.GetInt("Score5");
        Score6.text = "" + PlayerPrefs.GetInt("Score6");
        Score7.text = "" + PlayerPrefs.GetInt("Score7");
        Score8.text = "" + PlayerPrefs.GetInt("Score8");
        Score9.text = "" + PlayerPrefs.GetInt("Score9");
        Score10.text = "" + PlayerPrefs.GetInt("Score10");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
