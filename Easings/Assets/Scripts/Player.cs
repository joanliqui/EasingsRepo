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

    ConstantForce fuerzaConstante;

    private Vector2 screenBounds;

    private void Start()
    {
        fuerzaConstante = GetComponent<ConstantForce>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }

    private void Update()
    {
        ApplyMovement();
        Shot();
        MargingSpace(); 
    }

    void MargingSpace()
    {
        if(transform.position.x >= screenBounds.x)
        {
           
        }
    }

    void ApplyMovement()
    {
        Vector3 desiredForce = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            desiredForce += new Vector3(-100f, 0f,0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            desiredForce += new Vector3(100f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            desiredForce += new Vector3(0f, 100f, 0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            desiredForce += new Vector3(0f, -100f, 0f);
        }

        fuerzaConstante.relativeForce = desiredForce;
    }

    void Shot()
    {
        if (Input.GetButton("Jump"))
        {
            switch (shotLevel)
            {
                case Levels.level1:
                    ActivateEmission(particlesLV1);
                    DeaactivateEmission(particlesLV2);
                    DeaactivateEmission(particlesLV3);
                    break;
                case Levels.level2:
                    ActivateEmission(particlesLV2);
                    DeaactivateEmission(particlesLV1);
                    DeaactivateEmission(particlesLV3);
                    break;
                case Levels.level3:
                    ActivateEmission(particlesLV3);
                    DeaactivateEmission(particlesLV1);
                    DeaactivateEmission(particlesLV2);
                    break;
            }
        }
        else
        {
            DeaactivateEmission(particlesLV2);
            DeaactivateEmission(particlesLV1);
            DeaactivateEmission(particlesLV3);
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
