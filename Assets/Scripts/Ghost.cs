using System.Collections;
using UnityEngine;

public class Ghost : Character
{
    #region Singleton

    private static Ghost _ghost;

    public static Ghost Instance
    {
        get
        {
            if (_ghost == null)
            {
                _ghost = FindObjectOfType<Ghost>();
            }

            return _ghost;
        }
    }

    #endregion

    [HideInInspector] public bool isStune = false;
    private bool _move = true;

    public override void Movement()
    {
        var position = Player.Instance.transform.position;
        if (_move)
        {
            if (position.x > transform.position.x && Mathf.Abs(position.x - transform.position.x) > 0.5f &&
                !CheckCollider(Vector2.right))
            {
                Move(Vector2.right);
            }
            else if (position.x < transform.position.x && Mathf.Abs(position.x - transform.position.x) > 1 &&
                     !CheckCollider(Vector2.left))
            {
                Move(Vector2.left);
            }
            else if (position.y > transform.position.y && !CheckCollider(Vector2.up))
            {
                Move(Vector2.up);
            }
            else if (position.y < transform.position.y && !CheckCollider(Vector2.down))
            {
                Move(Vector2.down);
            }
            else
            {
                Move(new Vector2());
            }
        }

        if(isStune)
            StartCoroutine(StuneActive());
    }
    
    public IEnumerator StuneActive()
    {
        _move = false;
        yield return new WaitForSeconds(5f);
        isStune = false;
        _move = true;
    }
}