using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{

    public Ease enemyEase = new Ease();
    private Vector3 initPos;
    private Vector3 rotateHalf;

    private void Awake()
    {
        initPos = Vector3.zero;
        rotateHalf = new Vector3(90f, 0f, 180f);
    }

    void Start()
    {
        Sequence sec = DOTween.Sequence();
        sec.Append(transform.DOLocalMove(new Vector3(0f, 0f, 20f), 2f).SetEase(Ease.InCubic));
        sec.Append(transform.DOLocalMove(initPos, 2f).SetEase(Ease.InCubic));

        Sequence sec2 = DOTween.Sequence();
        sec2.Append(transform.DOLocalRotate(rotateHalf, 2f));

        sec.Insert(2.2f, sec2);

       
    }
}
