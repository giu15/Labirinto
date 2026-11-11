using UnityEngine;

//Referenciar a classe MonoBehaviour à classe Player
public class Player : MonoBehaviour
{
    //Variaveis
    public float velocidade;
    private Rigidbody2D rig;
    private Vector2 direcao;

    //Classe de inicialização
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    //Atualização da direção
    private void Update()
    {
        direcao = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    //Atualização da velocidade
    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + direcao * velocidade * Time.fixedDeltaTime);
    }


}
