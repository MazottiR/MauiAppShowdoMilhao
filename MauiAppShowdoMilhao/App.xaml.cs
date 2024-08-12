using MauiAppShowdoMilhao.Models;

namespace MauiAppShowdoMilhao
{
    public partial class App : Application
    {

        List<Pergunta> perguntas_faceis = new()
            {
                new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Líquido" },
                    new Alternativa { Correta = true, Descricao = "Sólido" },
                    new Alternativa { Correta = false, Descricao = "Gasoso" },
                    new Alternativa { Correta = false, Descricao = "Vaporoso" },
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Em que estado brasileiro nasceu a apresentadora Xuxa?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Rio de Janeiro" },
                    new Alternativa { Correta = true, Descricao = "Rio Grande do Sul" },
                    new Alternativa { Correta = false, Descricao = "Santa Catarina" },
                    new Alternativa { Correta = false, Descricao = "Goías" },
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual era o apelido da cantora Elis Regina?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Gauchinha" },
                    new Alternativa { Correta = true, Descricao = "Paulistinha" },
                    new Alternativa { Correta = false, Descricao = "Pimentinha'" },
                    new Alternativa { Correta = false, Descricao = "Andorinha" },
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Quem é a namorada do Mickey?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Margarida" },
                    new Alternativa { Correta = true, Descricao = "Minnie" },
                    new Alternativa { Correta = false, Descricao = "A Pequena Sereia'" },
                    new Alternativa { Correta = false, Descricao = "Olívia Palito" },
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Cuca" },
                    new Alternativa { Correta = true, Descricao = "Negrinho do Pastoreio" },
                    new Alternativa { Correta = false, Descricao = "Boitatá" },
                    new Alternativa { Correta = false, Descricao = "Saci Pererê" },
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "Fidel Castro nasceu em que país?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JAMAICA" },
                    new Alternativa { Correta = true, Descricao = "CUBA" },
                    new Alternativa { Correta = false, Descricao = "EL SALVADOR" },
                    new Alternativa { Correta = false, Descricao = "MÉXICO" },
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS" },
                    new Alternativa { Correta = true, Descricao = "MARECHAL RONDON" },
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO II" },
                    new Alternativa { Correta = false, Descricao = "MARECHAL DEODORO" },
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MARECHAL DEODORO" },
                    new Alternativa { Correta = true, Descricao = "BARÃO DE MAUÁ" },
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS" },
                    new Alternativa { Correta = false, Descricao = "MARQUÊS DE POMBAL" },
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Quem era o apresentador que reprovava os calouros tocand uma buzina?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "RAUL GIL" },
                    new Alternativa { Correta = true, Descricao = "BOLINHA" },
                    new Alternativa { Correta = false, Descricao = "FLÁVIO CAVALCANTI" },
                    new Alternativa { Correta = false, Descricao = "CHACRINHA" },
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "O que era Frankenstein, de Mary Shelley??",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MONSTRO" },
                    new Alternativa { Correta = true, Descricao = "GORILA" },
                    new Alternativa { Correta = false, Descricao = "PRÍNCIPE" },
                    new Alternativa { Correta = false, Descricao = "SAPO" },
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Qual é o signo do zodíaco de quem nasce no dia do ano-novo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "VIRGEM" },
                    new Alternativa { Correta = true, Descricao = "AQUÁRIO" },
                    new Alternativa { Correta = false, Descricao = "CAPRICÓRNIO" },
                    new Alternativa { Correta = false, Descricao = "ÁRIES" },
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "HARRISON FORD" },
                    new Alternativa { Correta = true, Descricao = "GERALD FORD" },
                    new Alternativa { Correta = false, Descricao = "HENRY FORD" },
                    new Alternativa { Correta = false, Descricao = "ANNA FORD" },
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PRETA" },
                    new Alternativa { Correta = true, Descricao = "VERMELHA" },
                    new Alternativa { Correta = false, Descricao = "AZUL" },
                    new Alternativa { Correta = false, Descricao = "VERDE" },
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "A água ferve a quantos graus centígrados?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "200" },
                    new Alternativa { Correta = true, Descricao = "100" },
                    new Alternativa { Correta = false, Descricao = "170" },
                    new Alternativa { Correta = false, Descricao = "220" },
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "A água ferve a quantos graus centígrados?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "200" },
                    new Alternativa { Correta = true, Descricao = "100" },
                    new Alternativa { Correta = false, Descricao = "170" },
                    new Alternativa { Correta = false, Descricao = "220" },
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "21 DE ABRIL" },
                    new Alternativa { Correta = true, Descricao = "12 DE OUTUBRO" },
                    new Alternativa { Correta = false, Descricao = "7 DE SETEMBRO" },
                    new Alternativa { Correta = false, Descricao = "25 DE DEZEMBRO" },
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "Qual lugar é também chamado de Santa Sé?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "VENEZA" },
                    new Alternativa { Correta = true, Descricao = "VITÓRIA" },
                    new Alternativa { Correta = false, Descricao = "VANCOUVER" },
                    new Alternativa { Correta = false, Descricao = "VATICANO" },
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Quem tem por lema a frase: “Sempre alerta”?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MÉDICOS" },
                    new Alternativa { Correta = true, Descricao = "ESCOTEIROS" },
                    new Alternativa { Correta = false, Descricao = "BOMBEIROS" },
                    new Alternativa { Correta = false, Descricao = "POLICIAIS" },
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "Quem foi o grande amor de Julieta?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ROMEU" },
                    new Alternativa { Correta = true, Descricao = "ORFEU" },
                    new Alternativa { Correta = false, Descricao = "HAMLET" },
                    new Alternativa { Correta = false, Descricao = "IAGO" },
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Quantos signos formam o zodíaco?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "NOVE" },
                    new Alternativa { Correta = true, Descricao = "DEZ" },
                    new Alternativa { Correta = false, Descricao = "ONZE" },
                    new Alternativa { Correta = false, Descricao = "DOZE" },
                }
            },
     };
        List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "SEIS" },
                    new Alternativa { Correta = true, Descricao = "OITO" },
                    new Alternativa { Correta = false, Descricao = "DEZ" },
                    new Alternativa { Correta = false, Descricao = "DOZE" },
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual é o país do tango?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "URUGUAI" },
                    new Alternativa { Correta = true, Descricao = "ARGENTINA" },
                    new Alternativa { Correta = false, Descricao = "PARAGUAI" },
                    new Alternativa { Correta = false, Descricao = "ESPANHA" },
                }
            },
            new Pergunta
            {
                Id= 3,
                Enunciado = "Que imperador pôs fogo em Roma?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "TRAJANO" },
                    new Alternativa { Correta = true, Descricao = "NERO" },
                    new Alternativa { Correta = false, Descricao = "BRUTUS" },
                    new Alternativa { Correta = false, Descricao = "ICALÍGULA" },
                }
            },
             new Pergunta
            {
                Id= 4,
                Enunciado = "Que imperador pôs fogo em Roma?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "TRAJANO" },
                    new Alternativa { Correta = true, Descricao = "NERO" },
                    new Alternativa { Correta = false, Descricao = "BRUTUS" },
                    new Alternativa { Correta = false, Descricao = "ICALÍGULA" },
                }
            },
             new Pergunta
            {
                Id= 5,
                Enunciado = "Que imperador pôs fogo em Roma?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "TRAJANO" },
                    new Alternativa { Correta = true, Descricao = "NERO" },
                    new Alternativa { Correta = false, Descricao = "BRUTUS" },
                    new Alternativa { Correta = false, Descricao = "ICALÍGULA" },
                }
            },
             new Pergunta
            {
                Id= 6,
                Enunciado = "Que imperador pôs fogo em Roma?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "TRAJANO" },
                    new Alternativa { Correta = true, Descricao = "NERO" },
                    new Alternativa { Correta = false, Descricao = "BRUTUS" },
                    new Alternativa { Correta = false, Descricao = "ICALÍGULA" },
                }
            },
             new Pergunta
            {
                Id= 7,
                Enunciado = "Que imperador pôs fogo em Roma?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "TRAJANO" },
                    new Alternativa { Correta = true, Descricao = "NERO" },
                    new Alternativa { Correta = false, Descricao = "BRUTUS" },
                    new Alternativa { Correta = false, Descricao = "ICALÍGULA" },
                }
            },
        };
    }
}
