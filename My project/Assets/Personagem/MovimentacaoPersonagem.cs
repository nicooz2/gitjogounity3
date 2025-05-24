using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoPersonagem : MonoBehaviour
{
    private Rigidbody2D b_Rigidbody2D;
    public LayerMask GroundLayers;
    private Transform b_GroundCheck1, b_GroundCheck2;
    
    private float faceDirectionX;
    public float moveDirectionX; 

    [SerializeField] private float minWalkSpeedX = .5f; 
    [SerializeField] private float walkAccelerationX = .14f;
    private float currentSpeedX;
    [SerializeField] private float maxWalkSpeedX = 5.5f;
    private float releaseDecelerationX = .25f;
    private float skidDecelerationX = .5f;
    private float skidTurnaroundX = 3.5f;

    [SerializeField] private float jumpSpeedY;
    public bool isGrounded;
    private bool isJumping;
    public float checkJump;
    private float tempoContaJump;
    public float tempoJump;

    private bool isChangingDirection;

    public ParticleSystem Poeira;

    AudioManager audioManager3;

    // Start is called before the first frame update
    void Start()
    {
        b_GroundCheck1 = transform.Find("Ground Check 1");
        b_GroundCheck2 = transform.Find("Ground Check 2");
        b_Rigidbody2D = GetComponent<Rigidbody2D>();

        audioManager3 = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        audioManager3.AtivarEfeitoSonoro(audioManager3.InicioFaseSom);
    }


    void FixedUpdate()
    {
        if(faceDirectionX !=0)
        {
            if (currentSpeedX == 0)
            {
                currentSpeedX = minWalkSpeedX;


            }
            else if (currentSpeedX < maxWalkSpeedX)
            {

                currentSpeedX = IncreaseWithinBound(currentSpeedX, walkAccelerationX, maxWalkSpeedX);

                
            }

        }else if (currentSpeedX > 0)
        {
            
            currentSpeedX = DecreaseWithinBound(currentSpeedX, releaseDecelerationX);
            
        }



        isChangingDirection = currentSpeedX > 0 && faceDirectionX * moveDirectionX < 0;


        if (isChangingDirection)
        {
            if (currentSpeedX > skidTurnaroundX)
            {
                moveDirectionX = -faceDirectionX;


                currentSpeedX = DecreaseWithinBound(currentSpeedX, skidDecelerationX, 0);
            }


            else
            {
                moveDirectionX = faceDirectionX;
                
            }
        }

            b_Rigidbody2D.velocity = new Vector2(moveDirectionX * currentSpeedX, b_Rigidbody2D.velocity.y);


        if (faceDirectionX > 0)
        {
            CriarPoeira();
            Poeira.transform.localScale = new Vector2(1, 1);
            transform.localScale = new Vector2(1, 1); // Olhando para a direita com 1
           

        }
        else if (faceDirectionX < 0)
        {
            CriarPoeira();
            Poeira.transform.localScale = new Vector2(-1, 1);
            transform.localScale = new Vector2(-1, 1); // Olhando para a esquerda com -1
            

        }

    }





    // Update is called once per frame
    void Update()
    {
        faceDirectionX = Input.GetAxisRaw("Horizontal");

        isGrounded = Physics2D.OverlapPoint(b_GroundCheck1.position, GroundLayers) || Physics2D.OverlapPoint(b_GroundCheck2.position, GroundLayers);

        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            audioManager3.AtivarEfeitoSonoro(audioManager3.PuloSom);
            isJumping = true;
            tempoContaJump = tempoJump;
            b_Rigidbody2D.velocity = Vector2.up * jumpSpeedY;
        }
        if(Input.GetKey(KeyCode.Space) && isJumping == true)
        {

            if (tempoContaJump > 0)
            {
                
                b_Rigidbody2D.velocity = Vector2.up * jumpSpeedY;
                tempoContaJump -= Time.deltaTime;

            } else
            {
                isJumping = false;
            }


        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }


    float IncreaseWithinBound(float val, float delta, float maxVal)
    {
        val += delta;

        if(val > maxVal)
        {

            val = maxVal;
        }

        return val;

    }

    float DecreaseWithinBound(float val, float delta, float minVal = 0)
    {
        val -= delta;
        if(val < minVal)
        {

            val = minVal;


        }

        return val;
    }

    void CriarPoeira()
    {
        Poeira.Play();
    }

}
