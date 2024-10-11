namespace CP2.Domain.Interfaces.Dtos
{
    public interface IFornecedorDto
    {
        int Id { get; set; }
        string Nome { get; set; }
        string CpfCnpj { get; set; }
        DateTime CriadoEm { get; set; }

        void Validate();
    }
}
