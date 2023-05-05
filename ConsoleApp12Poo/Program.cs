# 05/05/2023
using Microsoft.Win32;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

Teoria da Orientação a Objetos -> Desenvolvimento profissional de sistemas
    - Terceirização de serviços
    - Tipos não naturais ou estruturas heterogêneas
        - novos atributos e com diferentes tipos
        - novos serviços e/ou reutilizar já existentes
    - Poder reproduzir o relacionamento natural de uma sociedade
    - Conceitos
        - Classe e objeto (instância ou elemento)
            -atributos->aspectos estruturais(variáveis)
            - métodos->aspectos comportamentais / funcionais(operações)
                - construtor->garante que um objeto de uma classe seja instanciado
                - getters e setters -> métodos de acesso (leitura ou escrita)
        -Relacionamentos
            - objetos tendo relação com outros objetos
            - tipos
                - associação
                - herança
                - composição/agregação
        - Visibilidade de acesso
            - tipos:
                - public
                - protected
                - private
        -Tipos de classes
            - Padrão
            - Abstratas
            - Interfaces
    - Classes                               -> prestam serviços
        - Nativas ou 'Artificiais'           
                                            ->  1) por meio de um objeto instanciado
                                                2) a própria classe atende o serviço
        //declarou um objeto frase para o tipo string        
        String frase;
//instanciou o objeto frase com um texto inicial
frase = new String("turma de c# Atos 2023");
//ha um objeto com atributos e métodos da classe string
Console.WriteLine("A quantidade de caracteres da frase é: " + frase.Length());
Console.WriteLine("A frase em maiusculo: " + frase.ToUpper());
String outraFrase = Console.ReadLine();
Desafio / Exercício: pensando OO
    Um veículo entra num estacionamento e pode alugar o espaço por horas, dias ou meses. O valor da hora é 5 reais, do dia 50 reais e do mês 350 reais. O administrador do estacionamento pode querer visualizar os veículos presentes na
    garagem ou estacionamento, também pode querer saber os veículos que já passaram pelo estacionamento.
    Contudo, a garagem tem um espaço finito de vagas.
    Em geral, quando um veículo entra no estacionamento, são capturados os seguintes dados/informações:
        -placa
        - data de entrada
        - hora de entrada
        - cor veículo
        - marca
        - modelo
        - data de saida
        - hora de saida
        - valorPago
    Ao final, quando o veículo sai do estacionamento, o manobrista realiza a cobrança, baseado na data e hora de saída em relação a data e hora de entrada.
    Serviços:
        registrar a entrada do veiculo
        registrar a saida do veiculo
        calcular o valor da hospedagem
    Classe
        class Veiculo
{
    string placa;
    DateTime dataHoraEntrada;
    string cor;
    string marca;
    string modelo;
    DateTime dataHoraSaida;
    double valorPago;
    //construtor vazio
    public Veiculo()
    {
        this.dataHoraEntrada = DateTime.Now;
    }
    //construtor
    public Veiculo(string placa, string cor, string marca, string modelo)
    {
        this.placa = placa.ToUpper().Trim();
        this.cor = cor.ToUpper().Trim();
        this.marca = marca.ToUpper().Trim();
        this.modelo = modelo.ToUpper().Trim();
        this.dataHoraEntrada = DateTime.Now;
    }
    //reescrever o método Equals()
}
public class Principal
{
    public static void Main(string[] args)
    {
        Veiculo v1 = new Veiculo(); //assumindo que o objeto v1 está sendo instaciado pelo construtor vazio
                                    //em algum momento do código foi preciso colocar dados no objeto
        v1.placa = "IPL7154";
        v1.cor = "Branco";
        v1.marca = "Fiat";
        v1.modelo = "Palio Adventure";
        Console.WriteLine(v1.dataHoraEntrada)
                Veiculo v2 = new Veiculo("ITT7645", "preta", "fiat", "pulse");
        List<Veiculo> garagem = new List<Veiculo>();
        garagem.Add(v1);
        garagem.Add(v2);
        string placa, cor, marca, modelo;
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite placa: ");
            placa = Console.ReadLine();
            Console.Write("Digite cor: ");
            cor = Console.ReadLine();
            Console.Write("Digite marca: ");
            marca = Console.ReadLine();
            Console.Write("Digite modelo: ");
            modelo = Console.ReadLine();
            garagem.Add(new Veiculo(placa, cor, marca, modelo));
        }
    }
}
garagem[obj1, obj2, obj3, obj4, obj5]
       for (int i = 0; i < garagem.Size(); i++)
{
    if (garagem[i].placa == "IPL7154")
    {
        //
    }
}
foreach (var i in garagem)
{
    if (i.placa == "IPL7154")
    {
        //
    }
}
Uma Unidade de Saúde, ao receber pessoas para consultas, realiza cadastro do paciente (nome, cpf, dataNascimento, email). Feito isso, o paciente cadastrado participa de um processo de triagem (valida dados do paciente,
peso, altura, pressão arterial e temperatura). Em cima desses dados o técnico ou enfermeiro colocam a urgência
de atendimento (verde, amarelo, vermelho). Feito isso, o paciente é chamado a consulta, em que são guardados:
-paciente
- triagem
- nome e crm do médico
- prescrição gerada
UnidadeSaude
Paciente
Triagem
Consulta
ProfissionalSaude