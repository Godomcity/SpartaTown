using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectManager : MonoBehaviour
{
    [SerializeField] private Sprite penguinSprite;
    [SerializeField] private Sprite lizardSprite;

    [SerializeField] private AnimatorController penguinAnimationController;
    [SerializeField] private AnimatorController lizardAnimationController;

    [SerializeField] private Image characterSelectImage;
    [SerializeField] private GameObject characterSelectBackGround;

    [SerializeField] private SpriteRenderer playerMainSprite;
    [SerializeField] private Animator playerAnimator;

    public void CharacterSelectButton()
    {
        characterSelectBackGround.SetActive(true);
    }

    public void PenguinButton()
    {
        characterSelectBackGround.SetActive(false);
        characterSelectImage.sprite = penguinSprite;
    }

    public void LizardSelectButton()
    {
        playerMainSprite.sprite = lizardSprite;
        playerAnimator.runtimeAnimatorController = lizardAnimationController;
        characterSelectImage.sprite = lizardSprite;
        characterSelectBackGround.SetActive(false);
    }
}
