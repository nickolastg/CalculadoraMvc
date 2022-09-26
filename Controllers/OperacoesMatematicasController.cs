namespace CalculadoraMvc.Controllers;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CalculadoraMvc.Models;

public class OperacoesMatematicasController : Controller
{
    public IActionResult Somar()
    {
        return View();
    }

    public IActionResult Subtrair()
    {
        return View();
    }

    public IActionResult Multiplicar()
    {
        return View();
    }

    public IActionResult Dividir()
    {
        return View();
    }

    public IActionResult ResultadoDeSoma(double n1, double n2){
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 + n2;
        
        return View();
    }

    public IActionResult ResultadoDeSubtrair(double n1, double n2){
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 - n2;
        
        return View();
    }

    public IActionResult ResultadoDeMultiplicar(double n1, double n2){
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 * n2;
        
        return View();
    }

    public IActionResult ResultadoDeDividir(double n1, double n2){
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 / n2;
        
        return View();
    }
}