using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{

    public Ease enemyEase = new Ease();
    public float finalZ;
    public float initZ;
    public Vector3 rotateHalf;

    [SerializeField] ParticleSystem ps;
    public ParticleSystem straightShot;
    public ParticleSystem rearShot;
    public ParticleSystem autoAimShot;

    private Transform player;
    
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
        

    private void Start()
    {
        Sequence seq1 = DOTween.Sequence();
        seq1.Append(transform.DOLocalMoveZ(finalZ, 2f).SetEase(Ease.OutQuad));
        seq1.Append(transform.DOLocalMoveZ(initZ, 2f).SetEase(Ease.OutQuad));
        Sequence seq2 = DOTween.Sequence();
        seq2.Append(transform.DOLocalRotate(rotateHalf, 2f, RotateMode.LocalAxisAdd));
        seq2.Append(transform.DOLocalRotate(rotateHalf, 1f, RotateMode.LocalAxisAdd));

        seq1.Insert(2f, seq2);
        seq1.Insert(0.5f, DOTween.Sequence().AppendCallback(StraightShot));
        seq1.Insert(1f, DOTween.Sequence().AppendCallback(RearShot));
    }

    void StraightShot()
    {
        if (straightShot)
        {
            straightShot.Emit(1);
        }
    }

    void RearShot()
    {
        if (rearShot)
        {
            rearShot.Emit(1);
        }
    }

    void AutoShot()
    {
        if (autoAimShot)
        {
            autoAimShot.Emit(1);
        }
    }
}
