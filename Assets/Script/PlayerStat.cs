using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour {
    public int currentLevel;
    public int currentExp;
    public int[] toLevelUp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(currentExp >= toLevelUp[currentLevel])
        {
            currentLevel++;
        }
	}
    public void AddExperience(int experiencetoAdd)
    {
        currentExp += experiencetoAdd;
    }
}
