using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PacketComputer : ParentRacket
{
    [SerializeField] private Rigidbody2D ball;
    [SerializeField] private float _speedRacket;

    private Vector2 _directionRacket;

    private void Update()
    {
        MoveRacket();
    }

    private void MoveRacket()
    {
        if (ball.velocity.y > -3f)
        {
            if (ball.position.x > transform.position.x)
            {
                DirectionRacket(Vector2.right);

            }
            else if (ball.position.x < transform.position.x)
            {
                DirectionRacket(Vector2.left);
            }
        }
        else
        {
            if (transform.position.x > 0.0f)
            {
                DirectionRacket(Vector2.left);
            }
            else if (transform.position.x < 0.0f)
                DirectionRacket(Vector2.right);
        }
    }

    private void DirectionRacket(Vector2 horizontalVector)
    {
        _directionRacket = new Vector2(horizontalVector.x, 0) * _speedRacket * Time.deltaTime;
        transform.Translate(_directionRacket);
    }
}
