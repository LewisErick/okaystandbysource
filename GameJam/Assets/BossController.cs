﻿using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour {


    [SerializeField]
    private int healthPoints;

    public GameObject destroyParticles;

    public int maxHealth = 100;

    bool isAirshipDamaged;

    void Start()
    {
        healthPoints = maxHealth; //Su vida inicial es la maxima
    }
        

    //El Boss recibe daño. Si se le acaba la vida mata al Boss
    public void TakeDamage(int _damagePoints)
    {
        healthPoints -= _damagePoints;

        if (!isAirshipDamaged && healthPoints <= 50)
        {
            damageAirship();
        }
        else if (healthPoints <= 0)
        {
            Killed();
        }
    }

    //Muere el Boss. Destruye el GameObject e instancia particulas
    private void Killed()
    {
        Destroy(this.gameObject, 3f);
        if (destroyParticles != null)
        {
            GameObject particles = (GameObject) Instantiate(destroyParticles, this.transform.position, this.transform.rotation);
            Destroy(particles, 3f);
        }
    }

    private void damageAirship()
    {
        isAirshipDamaged = true;

        //DestroyShip

        //Active Asteroids
    }

}