using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnimation : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerAnimator.SetBool("isJumping", true);
            playerAnimator.SetBool("isWalking", false);
            Debug.Log("Jump");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerAnimator.SetBool("isJumping", false);
            playerAnimator.SetBool("isWalking", true);
        }
    }
}
