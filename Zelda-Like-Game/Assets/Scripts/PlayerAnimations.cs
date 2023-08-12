using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] PlayerMovement _playerMovement;
    [SerializeField] Animator _animation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_playerMovement.GetDirection().magnitude > 0.1f)
        {
            transform.rotation = Quaternion.LookRotation(_playerMovement.GetDirection());
        }
        _animation.SetFloat("Running", _playerMovement.GetDirection().magnitude);



    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _animation.SetTrigger("Attack");

        }
        if (Input.GetMouseButtonDown(1))
        {
            _animation.SetBool("Defend", true);
        }
        if(Input.GetMouseButtonUp(1))
        {
            _animation.SetBool("Defend", false);
        }
    }
}
