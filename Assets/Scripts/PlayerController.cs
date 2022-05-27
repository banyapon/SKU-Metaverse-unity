using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviourPun
{
    [HideInInspector] public float sensitivity;

    // GameManager Property
    private float _moveSpeed;
    private float _gravity;
    private float _jumpPower;
    private int _maxJumpCount;
    private Vector3 _thirdPersonCameraOffset;
    private Camera _mainCamera;

    // PlayerController Property
    private float _bodyAngle;
    private float _cameraAngle;
    private Vector2 _lookDir;
    private Vector3 _moveDir;
    private float _yVelocity = 0;
    private int _currentJumpCount = 0;
    private PlayerState _state = PlayerState.IDLE;

    // PlayerController Components
    private CharacterController _characterController;
    private Animator _animator;

    // InputManager CallBack Property
    private Vector2 _move;
    private Vector2 _look;
    private bool _jump;

    enum PlayerState
    {
        IDLE = 0,
        MOVE = 1,
        SIZE
    }

    void Awake()
    {
        if (!photonView.IsMine) return;
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    void Start()
    {
        if (!photonView.IsMine) return;
        SetPlayerSettings();
    }

    void Update()
    {
        if (!photonView.IsMine) return;
        SetPlayerInput();
        SetPlayerState();
    }

    void LateUpdate()
    {
        if (!photonView.IsMine) return;
        Look();
        SetBlendTree();
    }

    void SetPlayerSettings()
    {
        GameManager gameMananger = GameManager.Instance;

        // Player Settings
        sensitivity = gameMananger.sensitivity;

        _moveSpeed = gameMananger.moveSpeed;
        _gravity = gameMananger.gravity;
        _jumpPower = gameMananger.jumpPower;
        _maxJumpCount = gameMananger.maxJumpCount;

        // CharacterController Settings
        _characterController.slopeLimit = gameMananger.slopeLimit;
        _characterController.stepOffset = gameMananger.stepOffset;
        _characterController.skinWidth = gameMananger.skinWidth;
        _characterController.minMoveDistance = gameMananger.minMoveDistance;
        _characterController.radius = gameMananger.radius;
        _characterController.height = gameMananger.height;
        _characterController.center = gameMananger.center;

        // Animator Settings
        _animator.runtimeAnimatorController = gameMananger.runtimeAnimatorController;

        // Camera Settings
        _mainCamera = Camera.main;
    }

    void SetPlayerInput()
    {
        InputManager inputMananger = InputManager.Instance;

        // InputManager CallBack
        _move = inputMananger.move;
        _jump = inputMananger.jump;
        _look = inputMananger.look;
    }

    void SetPlayerState()
    {
        // State Pattern
        switch (_state)
        {
            case PlayerState.IDLE:
                Idle();
                Jump();
                break;

            case PlayerState.MOVE:
                Move();
                Jump();
                break;

            default:
                break;
        }
    }

    void Idle()
    {
        if (_move != Vector2.zero)
        {
            _state = PlayerState.MOVE;
        }
        else
        {
            _animator.SetInteger("State", 0);
            _moveDir = Vector3.zero;
            _moveDir.y = _yVelocity;
            _characterController.Move(_moveDir * Time.deltaTime * _moveSpeed);
        }
    }

    void Move()
    {
        if (_move == Vector2.zero)
        {
            _state = PlayerState.IDLE;
        }
        else
        {
            _animator.SetInteger("State", 1);
            _moveDir = new Vector3(_move.x, 0, _move.y).normalized;
            _moveDir = _mainCamera.transform.TransformDirection(_moveDir);
            _moveDir.y = _yVelocity;
            _characterController.Move(_moveDir * Time.deltaTime * _moveSpeed);
        }
    }

    void Jump()
    {
        if (_characterController.collisionFlags == CollisionFlags.Below)
        {
            _yVelocity = 0;
            _currentJumpCount = 0;
            _animator.SetBool("isJump", false);
        }

        if (_jump && _currentJumpCount < _maxJumpCount)
        {
            _currentJumpCount++;
            _yVelocity = _jumpPower;
            _animator.SetTrigger("doJump");
            _animator.SetBool("isJump", true);
        }

        _yVelocity += _gravity * Time.deltaTime;
    }

    void Look()
    {
        _lookDir = _look * Time.deltaTime * sensitivity;
        _bodyAngle += _lookDir.x;
        this.transform.localEulerAngles = new Vector3(0, _bodyAngle, 0);

        _cameraAngle += _lookDir.y;
        _cameraAngle = Mathf.Clamp(_cameraAngle, -30, 30);
        _mainCamera.transform.localEulerAngles = new Vector3(-_cameraAngle, 0, 0);
    }

    void SetBlendTree()
    {
        _animator.SetFloat("xDir", _move.x);
        _animator.SetFloat("zDir", _move.y);
    }
}