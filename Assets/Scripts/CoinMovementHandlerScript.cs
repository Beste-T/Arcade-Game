using DG.Tweening;
using UnityEngine;

public class CoinMovementHandlerScript : MonoBehaviour
{
    [SerializeField] private float cycleLenght;

    private Vector3 coinRotation;


    private void Start()
    {
        coinRotation = new Vector3 (0.0f, 360.0f, 0.0f);

        CoinMovement();    
    }

    private void CoinMovement()
    {
        transform.DOMoveY(1.5f,cycleLenght).SetEase(Ease.InOutSine).SetLoops(-1,LoopType.Yoyo);
        transform.DORotate(coinRotation, cycleLenght * 2, RotateMode.FastBeyond360)
                 .SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear).SetRelative();    
    }
   
}
