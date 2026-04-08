using UnityEngine;
using UnityEngine.InputSystem;

public class LocalMultiplayerController : MonoBehaviour
{
    public LocalMultiplayerManager manager;
    public PlayerInput playerInput;
    public Vector2 movementInput;
    public float speed = 5;
    public SpriteRenderer sr;
    public ParticleSystem ps;
    public AudioSource SFX;
    void Update()
    {
        transform.position += (Vector3)movementInput * speed * Time.deltaTime;
    }

    public void SetSprite(Sprite sprite)
    {
        sr.sprite = sprite;
        ps.textureSheetAnimation.SetSprite(0, sprite);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SFX.Play();
            Debug.Log("Player " + playerInput.playerIndex + ": Attacking!");
            manager.PlayerAttacking(playerInput);
        }
    }

    public void TakeDamage()
    {
        ps.Emit(15);
    }
}
