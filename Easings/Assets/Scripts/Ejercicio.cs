using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Ejercicio : MonoBehaviour
{
    private float minScale = 0f; 
    public float maxScale = 0.5f;
    public float time = 2.5f;
    public float finalPos;
    public Vector3 rotation = new Vector3(0f, 0f, -180);
    public Transform[] squares;
    public Transform[] triangles;
    public Transform[] circles;

    private void Awake()
    {
        for (int i = 0; i < squares.Length; i++)
        {
            squares[i].localScale = Vector2.zero;
        }
    }
    void Start()
    {
        #region SQUARES
        Sequence seq = DOTween.Sequence();
        seq.Append(squares[0].DOScale(maxScale, time).SetEase(Ease.InOutExpo));
        seq.Append(squares[0].DOScale(minScale, time).SetEase(Ease.InOutExpo));
        seq.SetLoops(-1);

        Sequence seq2 = DOTween.Sequence();
        seq2.Append(squares[1].DOScale(maxScale, time).SetEase(Ease.InOutCirc));
        seq2.Append(squares[1].DOScale(minScale, time).SetEase(Ease.InOutCirc));
        seq2.SetLoops(-1);

        Sequence seq3 = DOTween.Sequence();
        seq3.Append(squares[2].DOScale(maxScale, time).SetEase(Ease.InOutQuint));
        seq3.Append(squares[2].DOScale(minScale, time).SetEase(Ease.InOutQuint));
        seq3.SetLoops(-1);

        Sequence seq4 = DOTween.Sequence();
        seq4.Append(squares[3].DOScale(maxScale, time).SetEase(Ease.InOutQuart));
        seq4.Append(squares[3].DOScale(minScale, time).SetEase(Ease.InOutQuart));
        seq4.SetLoops(-1);

        Sequence seq5 = DOTween.Sequence();
        seq5.Append(squares[4].DOScale(maxScale, time).SetEase(Ease.InOutQuad));
        seq5.Append(squares[4].DOScale(minScale, time).SetEase(Ease.InOutQuad));
        seq5.SetLoops(-1);

        Sequence seq6 = DOTween.Sequence();
        seq6.Append(squares[5].DOScale(maxScale, time).SetEase(Ease.InOutSine));
        seq6.Append(squares[5].DOScale(minScale, time).SetEase(Ease.InOutSine));
        seq6.SetLoops(-1);

        Sequence seq7 = DOTween.Sequence();
        seq7.Append(squares[6].DOScale(maxScale, time).SetEase(Ease.InOutBack));
        seq7.Append(squares[6].DOScale(minScale, time).SetEase(Ease.InOutBack));
        seq7.SetLoops(-1);

        Sequence seq8 = DOTween.Sequence();
        seq8.Append(squares[7].DOScale(maxScale, time).SetEase(Ease.InOutBounce));
        seq8.Append(squares[7].DOScale(minScale, time).SetEase(Ease.InOutBounce));
        seq8.SetLoops(-1);

        Sequence seq9 = DOTween.Sequence();
        seq9.Append(squares[8].DOScale(maxScale, time).SetEase(Ease.InOutElastic));
        seq9.Append(squares[8].DOScale(minScale, time).SetEase(Ease.InOutElastic));
        seq9.SetLoops(-1);
        #endregion

        #region TRIANGLES
        Sequence seqT1 = DOTween.Sequence();
        seqT1.Append(triangles[0].DOLocalRotate(rotation, time,RotateMode.LocalAxisAdd).SetEase(Ease.InOutExpo));
        seqT1.Append(triangles[0].DORotate(rotation, time,RotateMode.LocalAxisAdd).SetEase(Ease.InOutExpo));
        seqT1.SetLoops(-1);

        Sequence seqT2 = DOTween.Sequence();
        seqT2.Append(triangles[1].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutCirc));
        seqT2.Append(triangles[1].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutCirc));
        seqT2.SetLoops(-1);

        Sequence seqT3 = DOTween.Sequence();
        seqT3.Append(triangles[2].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutQuint));
        seqT3.Append(triangles[2].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutQuint));
        seqT3.SetLoops(-1);

        Sequence seqT4 = DOTween.Sequence();
        seqT4.Append(triangles[3].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutQuart));
        seqT4.Append(triangles[3].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutQuart));
        seqT4.SetLoops(-1);

        Sequence seqT5 = DOTween.Sequence();
        seqT5.Append(triangles[4].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutQuad));
        seqT5.Append(triangles[4].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutQuad));
        seqT5.SetLoops(-1);

        Sequence seqT6 = DOTween.Sequence();
        seqT6.Append(triangles[5].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutSine));
        seqT6.Append(triangles[5].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutSine));
        seqT6.SetLoops(-1);

        Sequence seqT7 = DOTween.Sequence();
        seqT7.Append(triangles[6].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutBack));
        seqT7.Append(triangles[6].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutBack));
        seqT7.SetLoops(-1);

        Sequence seqT8 = DOTween.Sequence();
        seqT8.Append(triangles[7].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutBounce));
        seqT8.Append(triangles[7].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InOutBounce));
        seqT8.SetLoops(-1);

        Sequence seqT9 = DOTween.Sequence();
        seqT9.Append(triangles[8].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InElastic));
        seqT9.Append(triangles[8].DOLocalRotate(rotation, time, RotateMode.LocalAxisAdd).SetEase(Ease.InElastic));
        seqT9.SetLoops(-1);

        #endregion

        #region CIRCLES
        Sequence seqC1 = DOTween.Sequence();
        seqC1.Append(circles[0].DOMoveY(finalPos, time).SetEase(Ease.InOutExpo));
        seqC1.Append(circles[0].DOMoveY(-finalPos, time).SetEase(Ease.InOutExpo));
        seqC1.SetLoops(-1);
        #endregion

    }
}
