using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    [SerializeField] private List<Transform> _path;
    [SerializeField] private float _speed;

    private int _indexPoint = 0;

    private void Update()
    {
        if (transform.position.x == _path[_indexPoint].position.x)
            _indexPoint++;

        if (_indexPoint > _path.Count - 1)
            _indexPoint = 0;

        transform.position = Vector2.MoveTowards(transform.position, new Vector2(_path[_indexPoint].position.x, transform.position.y), _speed * Time.deltaTime);
    }
}
