using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntEnemy : MonoBehaviour {
    public int damageToGive;
    public GameObject damageBurst;
    public Transform hitPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
            Instantiate(damageBurst, hitPoint.position, hitPoint.rotation);
        {
            // Destroy(other.gameObject);
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
        }
    }
}
