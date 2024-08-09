namespace EmpWebAPI.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }
        public string cidade { get; set; }
        public string nuit {  get; set; }
        public string contacto { get; set; }
        public string codigoPostal { get; set; }
        public string email { get; set; }
        public int numFuncionarios { get; set; }

    }
}
