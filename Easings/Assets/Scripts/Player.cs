using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int lifes = 10;

    public ParticleSystem[] particlesLV1;
    public ParticleSystem[] particlesLV2;
    public ParticleSystem[] particlesLV3;

    public enum Levels
    {
        level1, level2, level3
    }
    public Levels shotLevel;

    private void Update()
    {
        if (Input.GetButton("Jump"))
        {
            switch (shotLevel)
            {
                case Levels.level1:

                    break;
                case Levels.level2:
                    break;
                case Levels.level3:
                    break;
            }
        }
        else
        {

        }
    }

    private void OnParticleCollision(GameObject other)
    {
        TakeDamage();
    }

    public void TakeDamage()
    {
        lifes--;
        Debug.Log(lifes);
    }

    private void ActivateEmission(ParticleSystem[] shots)
    {
        for (int i = 0; i < shots.Length; i++)
        {
            ParticleSystem.EmissionModule emidMod = shots[i].emission;
            emidMod.enabled = true;
        }
    }

    private void DeaactivateEmission(ParticleSystem[] shots)
    {
        for (int i = 0; i < shots.Length; i++)
        {
            ParticleSystem.EmissionModule emidMod = shots[i].emission;
            emidMod.enabled = false;
        }
    }
}
