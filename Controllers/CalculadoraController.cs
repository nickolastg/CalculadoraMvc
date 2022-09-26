namespace CalculadoraMvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using CalculadoraMvc.Models;


public class CalculadoraController : Controller
{

    public IActionResult Calculadora()
    {
        return View();
    }

    public IActionResult Operacao(string operacao, double numero1, double numero2)
    {
        var viewModel = new Calculadora()
        {
            Operacao = operacao,
            Numero1 = numero1,
            Numero2 = numero2,
            Resultado = 0,
            NomeOperacao = ""
        };

        if (viewModel.Operacao == "+")
        {
            viewModel.Resultado = viewModel.Numero1 + viewModel.Numero2;
            viewModel.NomeOperacao = "Soma";
            return View(viewModel);
        }
        else if (viewModel.Operacao == "-")
        {
            viewModel.Resultado = viewModel.Numero1 - viewModel.Numero2;
            viewModel.NomeOperacao = "Subtração";
            return View(viewModel);
        }
        else if (viewModel.Operacao == "*")
        {
            viewModel.Resultado = viewModel.Numero1 * viewModel.Numero2;
            viewModel.NomeOperacao = "Multiplicação";
            return View(viewModel);
        }
        else if (viewModel.Operacao == "/")
        {
            viewModel.Resultado = viewModel.Numero1 / viewModel.Numero2;
            viewModel.NomeOperacao = "Divisão";
            return View(viewModel);
        }else throw new ArgumentException("Operação inválida");
    }
}