using System.ComponentModel.DataAnnotations;

namespace CRUD_Empleados.Models.ViewModels
{
    public class ValidationModel
    {

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Departamento { get; set; }

        public decimal Salario { get; set; }
    }
}
