using UnityEngine;

public class RacketPlayer : ParentRacket
{
    [SerializeField] private float _speedRacket;
    private Vector2 _directionRacket;
    private float _horizontalVector;

    private void Update()
    {
        MoveRacket();
    }

    private void MoveRacket()
    {
        _horizontalVector = Input.GetAxis("Horizontal");

        _directionRacket = new Vector2(_horizontalVector, 0) * _speedRacket * Time.deltaTime;
        transform.Translate(_directionRacket);
    }
}
