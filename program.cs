using ProjetoHospedagem.Models;

Suite suite = new Suite("Premium", 3, 200);

// Cria hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
hospedes.Add(new Pessoa("João"));
hospedes.Add(new Pessoa("Maria"));

// Reserva
Reserva reserva = new Reserva(12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da diária: R$ {reserva.CalcularValorDiaria()}");