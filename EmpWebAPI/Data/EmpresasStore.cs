using EmpWebAPI.Models;
using EmpWebAPI.Models.ModelsDto;

namespace EmpWebAPI.Data
{
    public static class EmpresasStore
    {
        public static List<EmpresaDto> empresas = new List<EmpresaDto> 
        {
            new EmpresaDto{ Id=1,nome = "Total", numFuncionarios=400},
            new EmpresaDto{ Id=2,nome ="Mozal",numFuncionarios=700}
        };
    }
}
