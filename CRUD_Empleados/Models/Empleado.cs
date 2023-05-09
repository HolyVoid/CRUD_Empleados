using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Empleados.Models;

public partial class Empleado
{
    public int Id { get; set; }

    [Required(ErrorMessage ="Falta Completar")]
    [RegularExpression("^(([A-za-z]+[A-za-z]+[ ]+[A-za-z]+[A-za-z]+))", ErrorMessage ="Solo se Adminten Letras")]
    [Display(Name ="Nombre Completo")]
    public string Nombre { get; set; }

    [Required(ErrorMessage ="Introduzca Una Edad")]
    [Range(18,100,ErrorMessage ="Introduzca Una Edad Valida Mayor a 18")]
    public int Edad { get; set; }

    [Required(ErrorMessage ="Falta Completar")]
    [RegularExpression("^(([A-za-z]+[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Solo se Adminten Letras")]
    public string Departamento { get; set; }

    [Required(ErrorMessage ="Introduzca Un Valor Valido")]
    [Range(0,10000000,ErrorMessage ="El Valor Debe Ser Mayor que 0")]
    [RegularExpression("^(([0-9]+))", ErrorMessage = "Solo se Adminten Numeros")]
    public decimal Salario { get; set; }
}
