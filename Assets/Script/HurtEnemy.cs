using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{

  
        public int damageToGive;
        public GameObject damageBurst;
        public Transform HitPoint;
        public GameObject damageNumber;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {


        }
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Enemy")
            {
                other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
                Instantiate(damageBurst, HitPoint.position, HitPoint.rotation);
                var clone = (GameObject)Instantiate(damageNumber, HitPoint.position, Quaternion.Euler(Vector3.zero));

                clone.GetComponent<FloatNumber>().damageNumber = damageToGive;

            }
        }
    }
