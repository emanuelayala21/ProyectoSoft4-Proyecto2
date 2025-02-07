using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelected :MonoBehaviour {

    public enum Player { NinjaFrog, PinkMan, MaskDude }
    public Player playerSelected;

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController[] playerController;
    public Sprite[] playerRenderer;
    void Start() {
        switch(playerSelected) {
            case Player.NinjaFrog:
                spriteRenderer.sprite = playerRenderer[0];
                animator.runtimeAnimatorController = playerController[0];
                break;
            case Player.PinkMan:
                spriteRenderer.sprite = playerRenderer[1];
                animator.runtimeAnimatorController = playerController[1];
                break;
            case Player.MaskDude:
                spriteRenderer.sprite = playerRenderer[2];
                animator.runtimeAnimatorController = playerController[2];
                break;
            default:
                break;
        }

    }

    void Update() {

    }
}
