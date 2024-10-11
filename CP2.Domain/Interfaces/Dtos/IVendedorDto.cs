namespace CP2.Domain.Interfaces.Dtos
{
    public interface IVendedorDto
    {
        int Id { get; set; }
        string Nome { get; set; }
        string CpfCnpj { get; set; }
        DateTime CriadoEm { get; set; }

        void Validate();
    }
}
