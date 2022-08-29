using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Attack : MonoBehaviour
{
    private Animator _animator;
    private int _attackHash;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _attackHash = Animator.StringToHash("Attack");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            _animator.SetTrigger(_attackHash);
            
        }
    }
}
