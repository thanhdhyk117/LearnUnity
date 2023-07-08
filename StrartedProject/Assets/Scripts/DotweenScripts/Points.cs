using UnityEngine;
using DG.Tweening;
public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform _circleObj;
    [SerializeField] private float _circleValue = 2;
    void Start()
    {
        transform.DOMove(new Vector3(7.5f, 0, 0), _circleValue).SetEase(Ease.OutSine).SetLoops(-1, LoopType.Yoyo);

        transform.DORotate(new Vector3(180, 0, 0), _circleValue * 0.5f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
