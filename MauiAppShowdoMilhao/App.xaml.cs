using MauiAppShowdoMilhao.Models;
using MetalPerformanceShadersGraph;

namespace MauiAppShowdoMilhao
{
    public partial class App : Application
    {

        static List<Pergunta> perguntas_faceis = new()
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


        static List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
            {
                Id = 21,
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
                Id = 22,
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
                Id= 23,
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
                Id= 24,
                Enunciado = "Que profissional usa uma ferramenta chamada formão?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CARPINTEIRO" },
                    new Alternativa { Correta = true, Descricao = "RELOJOEIRO" },
                    new Alternativa { Correta = false, Descricao = "CONFEITEIRO" },
                    new Alternativa { Correta = false, Descricao = "BOMBEIRO" },
                }
            },
             new Pergunta
            {
                Id= 25,
                Enunciado = "Em qual estádio Pelé marcou seu milésimo gol?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MORUMBI" },
                    new Alternativa { Correta = true, Descricao = "PACAEMBU" },
                    new Alternativa { Correta = false, Descricao = "MARACANÃ" },
                    new Alternativa { Correta = false, Descricao = "MINEIRÃO" },
                }
            },
             new Pergunta
            {
                Id= 26,
                Enunciado = "O que é um oboé?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "VULCÃO" },
                    new Alternativa { Correta = true, Descricao = "COMIDA" },
                    new Alternativa { Correta = false, Descricao = "INSTRUMENTO MUSICAL" },
                    new Alternativa { Correta = false, Descricao = "TRIBO INDÍGENA" },
                }
            },
             new Pergunta
            {
                Id= 27,
                Enunciado = "Como eram chamados os pilotos suicidas da Segunda Guerra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CAMICASES" },
                    new Alternativa { Correta = true, Descricao = "SASHIMIS" },
                    new Alternativa { Correta = false, Descricao = "HARAQUIRIS" },
                    new Alternativa { Correta = false, Descricao = "SUMÔS" },
                }
            },
             new Pergunta
            {
                Id= 28,
                Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JAPÃO" },
                    new Alternativa { Correta = true, Descricao = "MÉXICO" },
                    new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa { Correta = false, Descricao = "ESTADOS UNIDOS" },
                }
            },
             new Pergunta
            {
                Id= 29,
                Enunciado = "Como é chamado quem nasce em Milão, na Itália?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MILANENSE" },
                    new Alternativa { Correta = true, Descricao = "MILANOSO" },
                    new Alternativa { Correta = false, Descricao = "MILISTA" },
                    new Alternativa { Correta = false, Descricao = "MILANÊS" },
                }
            },
             new Pergunta
            {
                Id= 30,
                Enunciado = "O que é gôndola?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "EMBARCAÇÃO" },
                    new Alternativa { Correta = true, Descricao = "BRINQUEDO" },
                    new Alternativa { Correta = false, Descricao = "MÚSICA" },
                    new Alternativa { Correta = false, Descricao = "SÍMBOLO" },
                }
            },
             new Pergunta
            {
                Id= 31,
                Enunciado = "Sashimi é um prato originário de qual país?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JAPÃO" },
                    new Alternativa { Correta = true, Descricao = "CHINA" },
                    new Alternativa { Correta = false, Descricao = "ÍNDIA" },
                    new Alternativa { Correta = false, Descricao = "INDONÉSIA" },
                }
            },
             new Pergunta
            {
                Id= 32,
                Enunciado = "Como é chamada a cantora que representa o papel principal em uma ópera?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PRIMEIRA DONA" },
                    new Alternativa { Correta = true, Descricao = "DONA-PRIMA" },
                    new Alternativa { Correta = false, Descricao = "PRIMA-DONA" },
                    new Alternativa { Correta = false, Descricao = "OBRA-PRIMA" },
                }
            },
             new Pergunta
            {
                Id= 33,
                Enunciado = "Peroba é uma espécie de?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "INSETO" },
                    new Alternativa { Correta = true, Descricao = "ÁRVORE" },
                    new Alternativa { Correta = false, Descricao = "VERME" },
                    new Alternativa { Correta = false, Descricao = "VERDURA" },
                }
            },
             new Pergunta
            {
                Id= 34,
                Enunciado = "O alpinismo é praticado em que lugar?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MAR" },
                    new Alternativa { Correta = true, Descricao = "MONTANHA" },
                    new Alternativa { Correta = false, Descricao = "RIO" },
                    new Alternativa { Correta = false, Descricao = "PRAIA" },
                }
            },
             new Pergunta
            {
                Id= 35,
                Enunciado = "O Coliseu é um monumento histórico de que cidade européia?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PARIS" },
                    new Alternativa { Correta = true, Descricao = "COPENHAGUE" },
                    new Alternativa { Correta = false, Descricao = "ROMA" },
                    new Alternativa { Correta = false, Descricao = "LONDRES" },
                }
            },
             new Pergunta
            {
                Id= 36,
                Enunciado = "Qual destas cartas custa 8 de elixir?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MEGACAVALEIRO" },
                    new Alternativa { Correta = true, Descricao = "P.E.K.K.A" },
                    new Alternativa { Correta = false, Descricao = "GOLEM" },
                    new Alternativa { Correta = false, Descricao = "LAVA HOUND" },
                }
            },
             new Pergunta
            {
                Id= 37,
                Enunciado = "Onde está localizado o rio Nilo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "EGITO" },
                    new Alternativa { Correta = true, Descricao = "ETIÓPIA" },
                    new Alternativa { Correta = false, Descricao = "TURQUÍA" },
                    new Alternativa { Correta = false, Descricao = "CARAPICUIBA" },
                }
            },
             new Pergunta
            {
                Id= 38,
                Enunciado = "Qual a fórmula química do sal de cozinho?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "H2O" },
                    new Alternativa { Correta = true, Descricao = "Co²" },
                    new Alternativa { Correta = false, Descricao = "NaCl" },
                    new Alternativa { Correta = false, Descricao = "He" },
                }
            },
             new Pergunta
            {
                Id= 39,
                Enunciado = "Qual dessas não é uma linguagem de programação?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "HTML" },
                    new Alternativa { Correta = true, Descricao = "JAVASCRIPT" },
                    new Alternativa { Correta = false, Descricao = "DELPHI" },
                    new Alternativa { Correta = false, Descricao = "ELECTRON" },
                }
            },
             new Pergunta
            {
                Id= 40,
                Enunciado = "Qual dessas é uma fase da lua?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ESCURA" },
                    new Alternativa { Correta = true, Descricao = "APARECENTE" },
                    new Alternativa { Correta = false, Descricao = "NOVA" },
                    new Alternativa { Correta = false, Descricao = "METAFASE" },
                }
            },
        };


        static List<Pergunta> perguntas_dificeis = new()
        {
            new Pergunta
            {
                Id = 41,
                Enunciado = "Em qual espécie o macho choca os ovos e a fêmea procura alimento?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ANDORINHA" },
                    new Alternativa { Correta = false, Descricao = "PATO SELVAGEM" },
                    new Alternativa { Correta = true, Descricao = "PINGUIM" },
                    new Alternativa { Correta = false, Descricao = "MARRECO" },
                }
            },
            new Pergunta
            {
                Id = 42,
                Enunciado = "Em qual país está localizado o “Muro das lamentações”?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ALEMANHA" },
                    new Alternativa { Correta = false, Descricao = "BRASIL" },
                    new Alternativa { Correta = false, Descricao = "VENEZUELA" },
                    new Alternativa { Correta = true, Descricao = "ISRAEL" },
                }
            },
            new Pergunta
            {
                Id= 43,
                Enunciado = "Qual desses países não fica na Ásia?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PAQUISTÃO" },
                    new Alternativa { Correta = false, Descricao = "JAPÃO" },
                    new Alternativa { Correta = false, Descricao = "TAILÂNDIA" },
                    new Alternativa { Correta = true, Descricao = "EGITO" },
                }
            },
             new Pergunta
            {
                Id= 44,
                Enunciado = "Qual desses astros de filmes de ação é belga?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ARNOLD SCHWARZENEGGER" },
                    new Alternativa { Correta = false, Descricao = "SYLVESTER STALLONE" },
                    new Alternativa { Correta = false, Descricao = "STEVEN SEAGAL" },
                    new Alternativa { Correta = true, Descricao = "JEAN CLAUDE VAN DAMME" },
                }
            },
             new Pergunta
            {
                Id= 45,
                Enunciado = "Onde foi conduzida a vitória das forças aliadas na Segunda Guerra Mundial?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CANNES" },
                    new Alternativa { Correta = true, Descricao = "NORMANDIA" },
                    new Alternativa { Correta = false, Descricao = "CAPRI" },
                    new Alternativa { Correta = false, Descricao = "MARSELHA" },
                }
            },
             new Pergunta
            {
                Id= 46,
                Enunciado = "Onde nasceu Van Gogh, o grande pintor impressionista?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "POLÔNIA" },
                    new Alternativa { Correta = false, Descricao = "FRANÇA" },
                    new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa { Correta = true, Descricao = "HOLANDA" },
                }
            },
             new Pergunta
            {
                Id= 47,
                Enunciado = "Qual é a primeira letra do alfabeto grego?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DELTA" },
                    new Alternativa { Correta = false, Descricao = "BETA" },
                    new Alternativa { Correta = true, Descricao = "ALFA" },
                    new Alternativa { Correta = false, Descricao = "GAMA" },
                }
            },
             new Pergunta
            {
                Id= 48,
                Enunciado = "Qual presidente brasileiro instituiu o AI-5?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "COSTA E SILVA" },
                    new Alternativa { Correta = false, Descricao = "ERNESTO GEISEL" },
                    new Alternativa { Correta = false, Descricao = "JOÃO FIGUEIREDO" },
                    new Alternativa { Correta = false, Descricao = "ITAMAR FRANCO" },
                }
            },
             new Pergunta
            {
                Id= 49,
                Enunciado = "O que significa literalmente Perestroika?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CONVERSÃO" },
                    new Alternativa { Correta = false, Descricao = "INVOLUÇÃO" },
                    new Alternativa { Correta = true, Descricao = "REESTRUTURAÇÃO" },
                    new Alternativa { Correta = false, Descricao = "REGRESSÃO" },
                }
            },
             new Pergunta
            {
                Id= 50,
                Enunciado = "Qual desses quatro pesos é o mais leve?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "10 ONÇAS" },
                    new Alternativa { Correta = true, Descricao = "10 GRAMAS" },
                    new Alternativa { Correta = false, Descricao = "10 QUILOS" },
                    new Alternativa { Correta = false, Descricao = "10 LIBRAS" },
                }
            },
             new Pergunta
            {
                Id= 51,
                Enunciado = "Brahma é o deus de que religião?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "HINDUÍSMO" },
                    new Alternativa { Correta = false, Descricao = "XINTOÍSMO" },
                    new Alternativa { Correta = false, Descricao = "BUDISMO" },
                    new Alternativa { Correta = false, Descricao = "ISLAMISMO" },
                }
            },
             new Pergunta
            {
                Id= 52,
                Enunciado = "Os nazistas foram julgados em:",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "BERLIM" },
                    new Alternativa { Correta = true, Descricao = "NUREMBERGUE" },
                    new Alternativa { Correta = false, Descricao = "MUNIQUE" },
                    new Alternativa { Correta = false, Descricao = "PARIS" },
                }
            },
             new Pergunta
            {
                Id= 53,
                Enunciado = "Que ramo da pecuária ocupa-se de bodes e cabras?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ASININO" },
                    new Alternativa { Correta = true, Descricao = "CAPRINO" },
                    new Alternativa { Correta = false, Descricao = "BUFALINO" },
                    new Alternativa { Correta = false, Descricao = "MUAR" },
                }
            },
             new Pergunta
            {
                Id= 54,
                Enunciado = "Qual oceano tem o maior volume de água?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ATLÂNTICO" },
                    new Alternativa { Correta = true, Descricao = "PACÍFICO" },
                    new Alternativa { Correta = false, Descricao = "ÍNDICO" },
                    new Alternativa { Correta = false, Descricao = "ÁRTICO" },
                }
            },
             new Pergunta
            {
                Id= 55,
                Enunciado = "Qual foi o último presidente militar do Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "FERNANDO COLLOR" },
                    new Alternativa { Correta = true, Descricao = "JOÃO FIGUEIREDO" },
                    new Alternativa { Correta = false, Descricao = "TANCREDO NEVES" },
                    new Alternativa { Correta = false, Descricao = "JOÃO GOULART" },
                }
            },
             new Pergunta
            {
                Id= 56,
                Enunciado = "Que conflito ideológico envolveu os EUA e a União Soviética?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "GUERRA FRIA" },
                    new Alternativa { Correta = false, Descricao = "GUERRA DO VIETNÃ" },
                    new Alternativa { Correta = false, Descricao = "GUERRA NAS ESTRELAS" },
                    new Alternativa { Correta = false, Descricao = "GUERRA DA CORÉIA" },
                }
            },
             new Pergunta
            {
                Id= 57,
                Enunciado = "O trapézio é um músculo que está situado:",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "NO PESCOÇO" },
                    new Alternativa { Correta = true, Descricao = "NO OMBRO" },
                    new Alternativa { Correta = false, Descricao = "NA CABEÇA" },
                    new Alternativa { Correta = false, Descricao = "NO BRAÇO" },
                }
            },
             new Pergunta
            {
                Id= 58,
                Enunciado = "Quem escreveu o livro “A sangue frio” em 1966?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "TRUMAN CAPOTE" },
                    new Alternativa { Correta = false, Descricao = "HENRY JAMES" },
                    new Alternativa { Correta = false, Descricao = "JOHN STEINBECK" },
                    new Alternativa { Correta = false, Descricao = "TONI MORRISON" },
                }
            },
             new Pergunta
            {
                Id= 59,
                Enunciado = "Quem escreveu “Ulisses” em 1922?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ERNEST HEMINGWAY" },
                    new Alternativa { Correta = false, Descricao = "MARCEL PROUST" },
                    new Alternativa { Correta = false, Descricao = "T.S. ELLIOT" },
                    new Alternativa { Correta = true, Descricao = "JAMES JOYCE" },
                }
            },
             new Pergunta
            {
                Id= 60,
                Enunciado = "Qual o símbolo químico do radônio?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Rr" },
                    new Alternativa { Correta = false, Descricao = "Rd" },
                    new Alternativa { Correta = true, Descricao = "Rn" },
                    new Alternativa { Correta = false, Descricao = "Ro" },
                }
            },
        };


        static List<Pergunta> perguntas_finais = new()
        {
            new Pergunta
            {
                Id = 61,
                Enunciado = "Qual atleta foi desclassificado por uso de doping nas Olimpíadas de 1988?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MIKE POWELL" },
                    new Alternativa { Correta = false, Descricao = "BEN JOHNSON" },
                    new Alternativa { Correta = true, Descricao = "CARL LEWIS" },
                    new Alternativa { Correta = false, Descricao = "LINFORD CHRISTIE" },
                }
            },
            new Pergunta
            {
                Id = 62,
                Enunciado = "Qual metal possui o símbolo Hg?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "FERRO" },
                    new Alternativa { Correta = false, Descricao = "AÇO" },
                    new Alternativa { Correta = true, Descricao = "MERCÚRIO" },
                    new Alternativa { Correta = false, Descricao = "OURO" },
                }
            },
            new Pergunta
            {
                Id = 63,
                Enunciado = "Qual é o apelido do time da Ponte Preta?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "FEITICEIRA" },
                    new Alternativa { Correta = false, Descricao = "RAPOSA" },
                    new Alternativa { Correta = true, Descricao = "BRUXA" },
                    new Alternativa { Correta = false, Descricao = "MACACA" },
                }
            },
        };


        static List<Pergunta> perguntas_sorteadas = new();

       
        public static Pergunta getRandomPerguntaFacil()
        {
            Random r = new Random();

            int sorteado = r.Next(1, 20);

            return perguntas_faceis[sorteado];

            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(1, 20);

                pergunta_sorteada = perguntas_faceis[sorteado];

                if (!perguntas_sorteadas.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                    break;
                }
            }

            return pergunta_sorteada;
        }
        public static Pergunta getRandomPerguntaMedia()
        {
            Random r = new Random();

            int sorteado = r.Next(21, 40);

            return perguntas_medias[sorteado];
        }

        public static Pergunta getRandomPerguntaDificil()
        {
            Random r = new Random();

            int sorteado = r.Next(41, 60);

            return perguntas_faceis[sorteado];
        }
        public static Pergunta getRandomPerguntaFinal()
        {
            Random r = new Random();

            int sorteado = r.Next(61, 63);

            return perguntas_medias[sorteado];
        }
    }
}
